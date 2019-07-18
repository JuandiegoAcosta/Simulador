using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Ventanilla
{
    public partial class FrmListaDatos : Form
    {
        public string Doc { get; set; }
        public string Nombre { get; set; }

        public FrmListaDatos()
        {
            InitializeComponent();
        }
        public void CrearLista<T>(List<T> ListaDatos)
        {
            var bindingList = new BindingList<T>(ListaDatos);
            var source = new BindingSource(bindingList, null);
            DGVlistaDatos.DataSource = source;
        }

        private void DGVlistaDatos_SelectionChanged(object sender, EventArgs e)
        {
           // ataGridViewRow row = this.DGVlistaDatos.Rows[e.];
          //  Doc = row.Cells["NroDocumento"].Value.ToString();
        }

        private void DGVlistaDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          //  DataGridViewRow row = this.DGVlistaDatos.Rows[e.RowIndex];
          //  Doc = row.Cells["NroDocumento"].Value.ToString();
        }

        private void BTAceptar_Click(object sender, EventArgs e)
        {         
            if (DGVlistaDatos.CurrentCell != null)
            {
                int i = DGVlistaDatos.CurrentCell.RowIndex;
                Doc = DGVlistaDatos["NroDocumento", i].Value.ToString();
                Nombre = DGVlistaDatos["Nombres", i].Value.ToString() + " " + DGVlistaDatos["Apellidos", i].Value.ToString();
                this.Close();
            }      
        }

        private void FrmListaDatos_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void BTCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
