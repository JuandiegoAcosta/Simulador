using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Controles
{
    public partial class DatosPersona : UserControl
    {
        public bool DatosValidos { get; set; }
        public DatosPersona()
        {
            
            InitializeComponent();
            gbDatos.Size = new Size(369, 89);
        }

        private void DatosPersona_Load(object sender, EventArgs e)
        {

        }
        private void Mostrar()
        {
        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {
            int lng = txtNumDoc.Text.Length;
            if (lng>8 && lng <12)
            {
                lblApPaterno.Text = "Razón Social";
                lblApPaterno.Visible = true;
                txtApPaterno.Visible = true;
                gbDatos.Size = new Size(369, 129);
            }
            else if (lng<9 && lng >7)
            {
                lblApPaterno.Text = "Apellido Paterno";
                lblApMaterno.Visible = true;
                lblApPaterno.Visible = true;
                lblNombre.Visible = true;
                txtApPaterno.Visible = true;
                txtApMaterno.Visible = true;
                txtNombre.Visible = true;
                gbDatos.Size = new Size(369, 200);
            }
            else
            {
                lblApPaterno.Visible = false;
                txtApPaterno.Visible=false;
                lblApMaterno.Visible=false;
                txtApMaterno.Visible=false;
                lblNombre.Visible = false;
                txtNombre.Visible=false;
                gbDatos.Size = new Size(369, 89);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            foreach (Control txtbox in this.gbDatos.Controls.OfType<TextBox>().ToList())
            {
                txtbox.Text = string.Empty;
            }
        }
    }
}
