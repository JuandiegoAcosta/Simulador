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
      private Int64 m_nro_cuenta = 0;

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

      private bool SetItem()
      {
         try
         {
            string _nroCuemta = TBNroCuenta.Text.Trim();
            if (!string.IsNullOrEmpty(_nroCuemta) && Int64.TryParse(_nroCuemta, out Int64 result))
            { m_nro_cuenta = result; }
            else
               return false;

            return true;

         }
         catch (Exception e)
         {
            MessageBox.Show(e.ToString());
            return false;
         }
      }

        private void BtValidar_Click(object sender, EventArgs e)
        {


         if (SetItem())
         {
            CuentasMethods validar = new CuentasMethods();
            var Cuenta = validar.ValidarCuenta(m_nro_cuenta);
            if (Cuenta is null)
            {
               MessageBox.Show("Cuenta no existente.");
               return;
            }  
            LbPersona.Text = "Cliente: " + Cuenta.Cliente;

            Lbestado.Text = "Estado: " + Cuenta.Estado;
            Lbmoneda.Text = Cuenta.Moneda;
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
        }
    }
}
