using CNegocio.Ventanilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Retiros :Base
    {
      private RetirosMethods retirosMethods = null;

      #region [Variables Globales]
      private decimal m_monto = default(decimal);
      private Int64 m_nroTarjeta = default(Int64);
      private int m_clave = default(int);
      private string m_doi = default(string);
      #endregion
      public Retiros()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
            
        }


      private bool SetItem()
      {
         try
         {
            
            if (!string.IsNullOrEmpty(this.monto1.TBMonto.Text.Trim()))
            { m_monto = Convert.ToDecimal(this.monto1.TBMonto.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.nroCuenta1.TBNroCuenta.Text.Trim()))
            { m_nroTarjeta = Convert.ToInt64(this.nroCuenta1.TBNroCuenta.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtClave.Text.Trim()))
            { m_clave = Convert.ToInt32(this.txtClave.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.doi1.TBDoi.Text.Trim()))
            { m_doi = this.doi1.TBDoi.Text.Trim(); }
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
                retirosMethods = new RetirosMethods();
                if (retirosMethods.InsertaRetiro(this.m_monto, this.m_nroTarjeta, this.m_clave, this.m_doi) > 0)
                    MessageBox.Show("Retiro con exito");
                else
                    MessageBox.Show("No se pudo generar el retiro");
            }
            else
            {
                MessageBox.Show("Se encontró campos vacios");
            }
        }

    

        private static Retiros _instance;
        public static Retiros instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Retiros();
                }

                return _instance;
            }
        }
    }
}
