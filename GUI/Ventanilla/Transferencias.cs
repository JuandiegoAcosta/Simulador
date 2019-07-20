using CNegocio.Ventanilla;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
           // nroCuenta1.LbTarjeta.Text = "Nro Cuenta / Tarjeta";
            nroCuenta1.BtValidar.Click += BtValidar_Click;
        }

        private void BtValidar_Click(object sender, EventArgs e)
        {
            int index = tipoMoneda1.CboMoneda.FindString(nroCuenta1.Lbmoneda.Text);
            tipoMoneda1.CboMoneda.SelectedIndex = index;
            tipoMoneda1.Enabled = false;
        }

        private bool SetItem()
      {
         CuentasTarjetasModel = new CuentasTarjetasModel();
         if (!string.IsNullOrEmpty(this.txtMonto.Text.Trim()))
            CuentasTarjetasModel.Monto = Convert.ToDecimal(this.txtMonto.Text.Trim());
         else
            return false;

         if (!string.IsNullOrEmpty(this.nroCuenta1.TBNroCuenta.Text.Trim()))
            CuentasTarjetasModel.NroCuenta = Convert.ToInt64(this.nroCuenta1.TBNroCuenta.Text.Trim());
         else
            return false;

         if (!string.IsNullOrEmpty(this.nroCuenta2.TBNroCuenta.Text.Trim()))
            CuentasTarjetasModel.NroCuentaDestino = Convert.ToInt64(this.nroCuenta2.TBNroCuenta.Text.Trim());
         else
            return false;

         if (!string.IsNullOrEmpty(this.nroCuenta1.dni1.TBDni.Text.Trim()))
            CuentasTarjetasModel.doi = Convert.ToInt32(this.nroCuenta1.dni1.TBDni.Text.Trim());
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
                StatusStrip o = this.TopLevelControl.Controls.Find("stStatus", true).FirstOrDefault() as StatusStrip;//o.Items[1].Text;
                CuentasTarjetasModel.Usuario = o.Items[1].Text;
               // CuentasTarjetasModel.NroTarjeta = 

                CuentasTarjetasModel.RowVersion = nroCuenta1.VersionCuenta;
                CuentasTarjetasModel.RowVersionD = nroCuenta2.VersionCuenta;
                string a = transferenciasMethods.RealizarTransferencia(CuentasTarjetasModel);
                if (a.Equals("Transferido"))
                {
                    MessageBox.Show("Operacion Realizada");
                    nroCuenta1.LimpiarControles();
                    nroCuenta2.LimpiarControles();
                    txtMonto.Clear();
                    nroCuenta1.dni1.TBDni.Clear();
                    clave1.TBClave.Clear();
                }             
            else
               MessageBox.Show("No se pudo realizar la operación: "+a);
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
