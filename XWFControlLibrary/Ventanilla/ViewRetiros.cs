using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using XWFControlLibrary.Config;
using XWFControlLibrary.Services;
using CNegocio.Ventanilla;

namespace XWFControlLibrary.Ventanilla
{
   public partial class ViewRetiros : UserControl
   {
      private _RetiroMethods methods = null;
      private Usd usd = null;
      private Eur eur = null;
      public ViewRetiros()
      {
         InitializeComponent();
         Init();
         methods = new _RetiroMethods();
      }

      private void Init()
      {
         txtMonto.btnViewMoney.TextChanged += BtnViewMoney_TextChanged;
      }

      private void BtnViewMoney_TextChanged(object sender, EventArgs e)
      {
         ExChange();
      }

      private void ViewRetiros_Load(object sender, EventArgs e)
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
               txtMonto.Text = Math.Round((value * usd.inverseRate),2).ToString();
               break;
            case "EUR":
               txtMonto.Text = Math.Round((value * eur.inverseRate),2).ToString();
               break;
         }
      }

      private void TxtNroCuenta_TextChanged(object sender, EventArgs e)
      {
         if (txtNroCuenta.TextLength >= 14 && txtNroCuenta.TextLength <= 18)
         {
            Int64 value = Convert.ToInt64(txtNroCuenta.Text);
            string[] result = null;
            if (methods.ConsultarClientePorNroCuenta(value,ref result))
            {
               SetCliente(result);
            }
            
         }
            
      }

      private void TxtDOI_TextChanged(object sender, EventArgs e)
      {

      }

      private void SetCliente(string[] x_result)
      {
         if (x_result != null && x_result.Length > 0)
         {
            txtNombre.Text = string.Concat(x_result[0]," ",x_result[1]);
            txtDocumento.Text = x_result[2];
            txtDOI.Text = x_result[2];
            txtNroCuenta.Text = x_result[3];
         }
      }

      private void GetItem()
      {
         if (!string.IsNullOrEmpty(txtNroCuenta.Text) && this.txtNroCuenta.TextLength >= 14)
         {
            
         }
         else
         {
            txtNroCuenta.Focus();
            errorProvider.SetError(txtNroCuenta, "Porfavor ingrese un numero de cuenta valido");
         }
      }

      private void BtnProceder_Click(object sender, EventArgs e)
      {
         //InsertaRetiro
         GetItem();
      }
   }
}
