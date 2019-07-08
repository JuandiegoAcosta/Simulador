using CNegocio.Ventanilla;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Transferencias : Base
    {
      private TransferenciasMethods transferenciasMethods;
      private CuentasTarjetasModel CuentasTarjetasModel;
        public Transferencias()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
            
        }

      private bool SetItem()
      {
         CuentasTarjetasModel = new CuentasTarjetasModel();
         if (!string.IsNullOrEmpty(this.txtMonto.Text.Trim()))
            CuentasTarjetasModel.Monto = Convert.ToDecimal(this.txtMonto.Text.Trim());
         else
            return false;

         if (!string.IsNullOrEmpty(this.txtNroCuentaOrigen.Text.Trim()))
            CuentasTarjetasModel.NroCuenta = Convert.ToInt64(this.txtNroCuentaOrigen.Text.Trim());
         else
            return false;

         if (!string.IsNullOrEmpty(this.txtNroCuentaDestino.Text.Trim()))
            CuentasTarjetasModel.NroCuentaDestino = Convert.ToInt64(this.txtNroCuentaDestino.Text.Trim());
         else
            return false;

         if (!string.IsNullOrEmpty(this.doi1.TBDoi.Text.Trim()))
            CuentasTarjetasModel.doi = Convert.ToInt32(this.doi1.TBDoi.Text.Trim());
         else
            return false;

         if (!string.IsNullOrEmpty(clave1.TBClave.Text.Trim()))
            CuentasTarjetasModel.clave = Convert.ToInt32(clave1.TBClave.Text.Trim());
         else
            return false;

         return true;
      }

        private void BTProceder_Click(object sender, EventArgs e)
        {

         if (SetItem())
         {
            transferenciasMethods = new TransferenciasMethods();
            if (transferenciasMethods.RealizarTransferencia(CuentasTarjetasModel) > 0)
               MessageBox.Show("Operacion Realizada");
            else
               MessageBox.Show("No se pudo realizar la operación");
         } 
        }

        private static Transferencias _instance;
        public static Transferencias instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transferencias();
                }

                return _instance;
            }
        }
    }
}
