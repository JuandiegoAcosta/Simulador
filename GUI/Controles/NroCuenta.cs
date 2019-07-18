using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio.Ventanilla;

namespace Sistema_Bancario.Controles
{
    public partial class NroCuenta : UserControl
    {
        public CuentasMethods validar;
        public byte[] VersionCuenta;
        public NroCuenta()
        {
            InitializeComponent();
        }
        private void TBNroCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void LimpiarControles()
        {
            TBNroCuenta.Clear();
           // groupBox1.Refresh();
            LbPersona.Visible = false;
            Lbestado.Visible = false;
            Lbmoneda.Visible = false;
        }

        private void BtValidar_Click(object sender, EventArgs e)
        {
            try
            {
                validar = new CuentasMethods();
                var Cuenta = validar.ValidarCuenta(Convert.ToInt64(TBNroCuenta.Text));
                
                LbPersona.Text = "Cliente: " + Cuenta.Cliente;

                Lbestado.Text = "Estado: " + Cuenta.Estado;
                Lbmoneda.Text = Cuenta.Moneda;
                VersionCuenta = Cuenta.Version;
                groupBox1.Enabled = true;
                if (Cuenta.TipoCuenta == "CORRIENTE")
                {
                    rbtnCorriente.Checked = true;
                }
                else
                {
                    rbtnAhorros.Checked = true;
                }
                LbPersona.Visible = true;
                groupBox1.Enabled = false;
                Lbestado.Visible = true;
                Lbmoneda.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }          
        }
    }
}
