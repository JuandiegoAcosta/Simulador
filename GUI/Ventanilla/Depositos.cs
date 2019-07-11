﻿using System;
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
using Sistema_Bancario.Controles;

namespace Sistema_Bancario.Ventanilla
{
   public partial class Depositos : Base
   {
      private DepositoMethods m_depositoMethods;
      private Deposito m_deposito;
        CambioMoneda cambioMoneda;
      public Depositos()
      {
         InitializeComponent();
         proceder1.BTProceder.Click += BTProceder_Click;
            tipoMoneda2.CboMoneda.SelectedValueChanged += CboMoneda_SelectedValueChanged;
            nroCuenta1.BtValidar.Click += BtValidar_Click;
      }

        private void BtValidar_Click(object sender, EventArgs e)
        {
            int index = tipoMoneda2.CboMoneda.FindString(nroCuenta1.Lbmoneda.Text);
            tipoMoneda2.CboMoneda.SelectedIndex = index;
        }

        private void CboMoneda_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!nroCuenta1.Lbmoneda.Text.Equals(tipoMoneda2.CboMoneda.Text))
            {
                MessageBox.Show("Se ha cambiado el tipo de moneda." +
                    "Se hara la conversion del monto ingresado");
                Precios TipoCambio = new Precios();
                panel1.Controls.Add(TipoCambio);
            }
            else
            {
                if (panel1.Controls.Count == 1)
                {
                    panel1.Controls.RemoveAt(0);
                }
            }
        }

        private bool SetItem()
      {
         try
         {
            m_deposito = new Deposito();

            if (!string.IsNullOrEmpty(this.nroCuenta1.TBNroCuenta.Text.Trim()))
            { m_deposito.NroCuenta = this.nroCuenta1.TBNroCuenta.Text.Trim(); }
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

        private void Button1_Click(object sender, EventArgs e)
        {
            panel1.Height = 150;
            button1.Location = new Point(27,380);
            cambioMoneda = new CambioMoneda();
            cambioMoneda.txtConversion.TextChanged += TxtConversion_TextChanged;
            int index=cambioMoneda.tipoMoneda1.CboMoneda.FindString(nroCuenta1.Lbmoneda.Text);
            cambioMoneda.tipoMoneda1.CboMoneda.SelectedIndex = index;
            panel1.Controls.Add(cambioMoneda);
            txtMonto.ReadOnly = true;
            
        }


        private void TxtConversion_TextChanged(object sender, EventArgs e)
        {
            txtMonto.Text = cambioMoneda.txtConversion.Text;
        }
    }
}
