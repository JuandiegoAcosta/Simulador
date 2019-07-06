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
    public partial class Retiros : Sistema_Bancario.Base
    {
      private RetirosMethods retirosMethods = null;

      #region [Variables Globales]
      private decimal m_monto = default(decimal);
      private int m_nroTarjeta = default(int);
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
            
            if (!string.IsNullOrEmpty(this.txtMonto.Text.Trim()))
            { m_monto = Convert.ToDecimal(this.txtMonto.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtNroTargeta.Text.Trim()))
            { m_nroTarjeta = Convert.ToInt32(this.txtNroTargeta.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtClave.Text.Trim()))
            { m_clave = Convert.ToInt32(this.txtClave.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtDoi.Text.Trim()))
            { m_doi = this.txtDoi.Text.Trim(); }
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
            if(retirosMethods.InsertaRetiro(this.m_monto, this.m_nroTarjeta, this.m_clave, this.m_doi) > 0)
               MessageBox.Show("Retiro con exito");
            else
               MessageBox.Show("No se pudo generar el retiro");
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
