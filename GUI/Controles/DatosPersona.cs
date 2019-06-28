using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Sistema_Bancario.Controles
{
    public partial class DatosPersona : UserControl
    {
        public string NumDoc;
        public int TipoDoc;
        public string ApPaterno;
        public string ApMaterno;
        public string Nombres;

        public DatosPersona()
        {

            InitializeComponent();
          //  gbDatos.Size = new Size(369, 89);
        }

        private void txtNumDoc_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]*$");
            MatchCollection matches = regex.Matches(txtNumDoc.Text);

            if (matches.Count > 0)
            {
                int lng = txtNumDoc.Text.Length;
                if (lng > 8 && lng < 12)
                {
                    lblApPaterno.Text = "Razón Social";
                    lblApPaterno.Visible = true;
                    txtApPaterno.Visible = true;
                    gbDatos.Size = new Size(369, 129);
                    TipoDoc = 1;
                }
                else if (lng < 9 && lng > 7)
                {
                    lblApPaterno.Text = "Apellido Paterno";
                    lblApMaterno.Visible = true;
                    lblApPaterno.Visible = true;
                    lblNombre.Visible = true;
                    txtApPaterno.Visible = true;
                    txtApMaterno.Visible = true;
                    txtNombre.Visible = true;
                    gbDatos.Size = new Size(369, 200);
                    TipoDoc = 2;
                }
                else
                {
                    lblApPaterno.Visible = false;
                    txtApPaterno.Visible = false;
                    lblApMaterno.Visible = false;
                    txtApMaterno.Visible = false;
                    lblNombre.Visible = false;
                    txtNombre.Visible = false;
                    gbDatos.Size = new Size(369, 89);
                }
            }
            else
                txtNumDoc.Clear();
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control txtbox in this.gbDatos.Controls.OfType<TextBox>().ToList())
            {
                txtbox.Text = string.Empty;
            }
        }

        private void DatosPersona_Load(object sender, EventArgs e)
        {
             
        }
    }
}
