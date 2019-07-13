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

        private void BtValidar_Click(object sender, EventArgs e)
        {
           
            CuentasMethods validar = new CuentasMethods();
           var Cuenta=  validar.ValidarCuenta(Convert.ToInt64(TBNroCuenta.Text));
            LbPersona.Text = "Cliente: "+Cuenta.Cliente;
            lbTipocuenta.Text ="Tipo cuenta: " + Cuenta.TipoCuenta;
            Lbestado.Text ="Estado: "+ Cuenta.Estado;
            Lbmoneda.Text = Cuenta.Moneda;

            LbPersona.Visible = true;
            lbTipocuenta.Visible = true;
            Lbestado.Visible = true;
            Lbmoneda.Visible = true;

        }
    }
}
