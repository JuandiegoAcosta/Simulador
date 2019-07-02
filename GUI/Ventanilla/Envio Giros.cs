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
    public partial class Envio_Giros : Sistema_Bancario.Base
    {
      private GirosMethods girosMethods;

      #region [ Variables Globales ]
      private int DNIorigen = default(int);
      private int DNIdestino = default(int);
      private double monto = default(double);
      private int clave = default(int);
      #endregion
      public Envio_Giros()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
        }

      private bool SetItem()
      {
         try
         {
            if (!string.IsNullOrEmpty(this.txtMonto.Text.Trim()))
            { monto = Convert.ToDouble(this.txtMonto.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtClave.Text.Trim()))
            { clave = Convert.ToInt32(this.txtClave.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtDNIOrigen.Text.Trim()))
            { DNIorigen= Convert.ToInt32(this.txtDNIOrigen.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtDNIDestino.Text.Trim()))
            { DNIdestino = Convert.ToInt32(this.txtDNIDestino.Text.Trim()); }
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
            girosMethods = new GirosMethods();
            girosMethods.EnviarGiro(monto, clave, DNIorigen, DNIdestino);

            MessageBox.Show("Giro Enviado");
         }
        }

        private static Envio_Giros _instance;
        public static Envio_Giros instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Envio_Giros();
                }

                return _instance;
            }
        }
    }
}
