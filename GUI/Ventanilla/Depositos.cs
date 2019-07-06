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
using Modelos.Modelos;

namespace Sistema_Bancario.Ventanilla
{
   public partial class Depositos : Base
   {
      private DepositoMethods m_depositoMethods;
      private Deposito m_deposito;
      public Depositos()
      {
         InitializeComponent();
         proceder1.BTProceder.Click += BTProceder_Click;
      }


      private bool SetItem()
      {
         try
         {
            m_deposito = new Deposito();

            if (!string.IsNullOrEmpty(this.txtNroCuenta.Text.Trim()))
            { m_deposito.NroCuenta = this.txtNroCuenta.Text.Trim(); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtMonto.Text.Trim()))
            { m_deposito.Monto = Convert.ToDecimal(this.txtMonto.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtDoi.Text.Trim()))
            { m_deposito.Doi = this.txtDoi.Text.Trim(); }
            else
            { return false; }

            return true;
         }
         catch (Exception)
         {
            return false;
         }
      }

      private void BTProceder_Click(object sender, EventArgs e)
      {
         if (SetItem())
         {
            m_depositoMethods = new DepositoMethods();
            if (m_depositoMethods.insert(m_deposito))
               MessageBox.Show("Operacion Realizada");
            else
               MessageBox.Show("No se pudo realizar la operación");
         }
      }


      private static Depositos _instance;
      public static Depositos instance
      {
         get
         {
            if (_instance == null)
            {
               _instance = new Depositos();
            }

            return _instance;
         }
      }
   }
}
