using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XWFControlLibrary.Config;
using XWFControlLibrary.Services;

namespace XWFControlLibrary.Ventanilla
{
   public partial class ViewTransferencia : UserControl
   {
      private Usd usd = null;
      private Eur eur = null;

      public ViewTransferencia()
      {
         InitializeComponent();
         Init();
      }
      private void ViewTransferencia_Load(object sender, EventArgs e)
      {
         SetExchange();
      }
      private void Init()
      {
         txtMonto.btnViewMoney.TextChanged += BtnViewMoney_TextChanged;
      }

      private void BtnViewMoney_TextChanged(object sender, EventArgs e)
      {
         ExChange();
      }
      private void TxtValue_TextChanged(object sender, EventArgs e)
      {
         ExChange();
      }

      private void ExChange()
      {
         if (string.IsNullOrEmpty(txtValue.Text))
         {
            txtMonto.Text = string.Empty;
            return;
         }
            
         decimal value = Convert.ToDecimal(txtValue.Text);

         switch (txtMonto.btnViewMoney.Text)
         {
            case "PEN":
               txtMonto.Text = value.ToString();
               break;
            case "USD":
               txtMonto.Text = Math.Round((value * usd.inverseRate), 2).ToString();
               break;
            case "EUR":
               txtMonto.Text = Math.Round((value * eur.inverseRate), 2).ToString();
               break;
         }
      }
      private void SetExchange()
      {
         Money money = new Money();
         usd = money.GetUSD();
         txtCodeUSD.Text = usd.code;
         txtNombreUSD.Text = usd.name;
         txtTarifaUSD.Text = Math.Round(usd.inverseRate, 2).ToString();
         txtInversoUSD.Text = Math.Round(usd.rate, 2).ToString();
         eur = money.GetEUR();
         txtCodeEUR.Text = eur.code;
         txtNombreEUR.Text = eur.name;
         txtTarifaEUR.Text = Math.Round(eur.inverseRate, 2).ToString();
         txtInversoEUR.Text = Math.Round(eur.rate, 2).ToString();
      }

      
   }
}
