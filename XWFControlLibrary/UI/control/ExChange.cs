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

namespace XWFControlLibrary.UI.control
{
   public partial class ExChange : UserControl
   {
      private Usd usd = null;
      private Eur eur = null;
      public ExChange()
      {
         InitializeComponent();
      }

      private void ExChange_Load(object sender, EventArgs e)
      {
         SetExchange();
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
