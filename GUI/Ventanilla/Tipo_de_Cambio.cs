using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelos.Modelos;

namespace Sistema_Bancario.Froms_opciones
{
   public partial class Tipo_de_Cambio : Base
   {
      private TipoCambioModel m_tipocambio;

      public Tipo_de_Cambio()
      {
         InitializeComponent();
         this.proceder1.BTProceder.Click += BTProceder_Click;
      }

      private bool setItem()
      {
         try
         {

            m_tipocambio = new TipoCambioModel();

            if (this.cmbMonedaOrigen.SelectedValue != null)
            { m_tipocambio.Monedaorigen = (int)this.cmbMonedaOrigen.SelectedValue; }
            else
            { return false; }

            if (this.cmbMonedaDestino.SelectedValue != null)
            { m_tipocambio.Monedaorigen = (int)this.cmbMonedaDestino.SelectedValue; }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtMonto.Text.Trim()))
            { m_tipocambio.Montocompra = Convert.ToDecimal(this.txtMonto.Text.Trim()); }
            else
            { return false; }

            if (!string.IsNullOrEmpty(this.txtConversion.Text.Trim()))
            { m_tipocambio.Montoventa = Convert.ToDecimal(this.txtConversion.Text.Trim()); }
            else
            { return false; }

            return true;

         }
         catch (Exception)
         {
            return false;
         }
      }

      private static Tipo_de_Cambio _instance;
      public static Tipo_de_Cambio instance
      {
         get
         {
            if (_instance == null)
            {
               _instance = new Tipo_de_Cambio();
            }

            return _instance;
         }
      }


      private void BTProceder_Click(object sender, EventArgs e)
      {
         if (setItem())
         {

         }
      }
   }
}
