using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XWFControlLibrary.Services;
using XWFControlLibrary.Config;

namespace XWFControlLibrary.Ventanilla
{
   public partial class ViewDeposito : UserControl
   {
      private Usd usd = null;
      private Eur eur = null;
      public ViewDeposito()
      {
         InitializeComponent();
         Init();
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

   }
}
