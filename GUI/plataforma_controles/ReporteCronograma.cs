using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio.Plataforma;
using Modelos.Modelos;
using Modelos.Session;
using System.IO;
using DocumentFormat.OpenXml;
using ClosedXML.Excel;

namespace Sistema_Bancario.plataforma_controles
{
    public partial class ReporteCronograma : UserControl
    {
        private BLPrestamo BLPrestamo = new BLPrestamo();

        public ReporteCronograma(ISession sesion)
        {
            InitializeComponent();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            string codigo = this.txtCodigo.Text;

            var objeto = this.BLPrestamo.prestamoSelectbyID(codigo);

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarPrestamo(objeto);
        }

        private void buscarPrestamo(List<PrestamosModel> objetos)
        {
            string[][] orden = new string[4][];

            orden[0] = new string[] { "ID", "Codigo", "80" };
            orden[1] = new string[] { "FechaPrestamo", "Fecha de Prestamo", "150" };
            orden[2] = new string[] { "Cuenta", "Cuenta", "200" };
            orden[3] = new string[] { "MontoPrestamo", "Codigo", "100" };


            if (objetos != null)
            {
                using (Ayuda.FormHelp2 formHelp1 = new Ayuda.FormHelp2())
                {
                    formHelp1.setList(objetos, orden);
                    formHelp1.ShowDialog();

                    if (formHelp1.EstaAceptado())
                    {
                        var dato = formHelp1.getObject<PrestamosModel>();
                        if (dato != null)
                        {
                            var datos = this.BLPrestamo.CronogramaPagosModelSelectbyIdPrestamo(dato.Id);
                        }
                    }
                }
            }
        }

        private void cronograma2gui(List<CronogramaPagosModel> cronogramaPagosModels)
        {
            this.dataGridView1.Rows.Clear();


            foreach (var item in cronogramaPagosModels)
            {
                this.dataGridView1.Rows.Add(item.Id.ToString(), item.Fechapago.ToString(), item.Monto.ToString(), item.Estado);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //Creating DataTable
            DataTable dt = new DataTable();

            //Adding the Columns
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            SaveFileDialog x = new SaveFileDialog();
            x.Filter = "xlsx files (*.xlsx)|*.xlsx";
            x.FileName = $"Exportacion{DateTime.Now.ToLongDateString()}.xlsx";

            if (x.ShowDialog() == DialogResult.OK)
            {
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Cronogramas");
                    wb.SaveAs(x.FileName);
                }
            }
        }
    }
}
