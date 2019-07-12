using CNegocio.Ventanilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario
{
    public partial class Cuotas : Base
    {
        private CuotasMethods GetCuotasMethods;
        public Cuotas()
        {
            InitializeComponent();
           
            proceder1.BTProceder.Click += BTProceder_Click;

        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            GetCuotasMethods = new CuotasMethods();
            int i = GridCuotas.CurrentCell.RowIndex;
         //   int i = GridCuotas.CurrentRow.Cells[0].Value;
          //  Convert.ToInt32(GridCuotas[i, 0].Value);
            GetCuotasMethods.CuotasInsert(Convert.ToInt32(GridCuotas[i,0].Value), "Usuario");
        }

        private static Cuotas _instance;

        public static Cuotas getinstance()
        {
            if (_instance == null)
            {
                _instance = new Cuotas();
            }

            return _instance;
        }

        private void BTBuscarCuota_Click(object sender, EventArgs e)
        {
            GetCuotasMethods = new CuotasMethods();
            
       //     MessageBox.Show(GetCuotasMethods.ObtenerPrestamos(nroCuenta1.TBNroCuenta.Text).ToString());
            var bindingList = new BindingList<object>(GetCuotasMethods.ObtenerPrestamos(nro_Documento1.TBNroDocumento.Text));
            var source = new BindingSource(bindingList, null);
            GridPrestamos.DataSource = source;
           // this.GridPrestamos.DataSource = GetCuotasMethods.ObtenerPrestamos(nroCuenta1.TBNroCuenta.Text);
            //   this.GridPrestamos.DataSource = new BindingSource(GetCuotasMethods.ObtenerPrestamos(nroCuenta1.TBNroCuenta.Text));
        }

        private void GridPrestamos_SelectionChanged(object sender, EventArgs e)
        {
         //   DataGridViewRow selectedRow = GridPrestamos.Rows[e.];
          //  GridPrestamos.SelectedRows.
        }

        private void GridPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = GridPrestamos.Rows[i];
            int ID = (int)selectedRow.Cells[0].Value;
            //CuotasSelect           
            var bindingList = new BindingList<object>(GetCuotasMethods.CuotasSelect(ID));
            var source = new BindingSource(bindingList, null);
            GridCuotas.DataSource = source;

        }
    }
}
