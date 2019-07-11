using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Modelos;

namespace Sistema_Bancario.Controles
{
    public partial class CambioMoneda : UserControl
    {
        private TipoCambioModel m_tipocambio;
        public CambioMoneda()
        {
            InitializeComponent();        
            monto1.TBMonto.TextChanged += TBMonto_TextChanged;
            tipoMoneda1.CboMoneda.SelectedIndexChanged += CboMoneda_SelectedIndexChanged;
            tipoMoneda2.CboMoneda.SelectedIndexChanged += CboMoneda_SelectedIndexChanged1;
        }

        private void CboMoneda_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
        }

        private void CboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tipoMoneda1.CboMoneda.Text.Equals("Soles"))
            {
                Divir(true);
            }
        }

        private bool setItem()
        {
            try
            {

                m_tipocambio = new TipoCambioModel();

                if (this.tipoMoneda1.CboMoneda.SelectedValue != null)
                { m_tipocambio.Monedaorigen = (int)this.tipoMoneda1.CboMoneda.SelectedValue; }
                else
                { return false; }

                if (this.tipoMoneda2.CboMoneda.SelectedValue != null)
                { m_tipocambio.Monedaorigen = (int)this.tipoMoneda2.CboMoneda.SelectedValue; }
                else
                { return false; }

                if (!string.IsNullOrEmpty(this.monto1.TBMonto.Text.Trim()))
                { m_tipocambio.Montocompra = Convert.ToDecimal(this.monto1.TBMonto.Text.Trim()); }
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
        private void TBMonto_TextChanged(object sender, EventArgs e)
        {
            Multiplicar(true);
        }
        public void Multiplicar(bool flag)
        {
            if (monto1.TBMonto.Text != "")
            {
                Decimal A = Convert.ToDecimal(precios1.LbCompraDolares.Text.ToString());
                Decimal B = Convert.ToDecimal(monto1.TBMonto.Text.ToString());
                Decimal D = Convert.ToDecimal(precios1.LbVentaDolares.Text.ToString());
                if (flag == true)
                {
                    Decimal C = A * B;
                    txtConversion.Text = Convert.ToString(C);
                }
                else if (flag == false)
                {
                    Decimal C = D * B;
                    txtConversion.Text = Convert.ToString(C);
                }
            }
            else
            {
                txtConversion.Text = "";
            }
        }
        public void Divir(bool flag)
        {
            if (monto1.TBMonto.Text != "")
            {
                Decimal A = Convert.ToDecimal(precios1.LbCompraDolares.Text.ToString());
                Decimal B = Convert.ToDecimal(monto1.TBMonto.Text.ToString());
                Decimal D = Convert.ToDecimal(precios1.LbVentaDolares.Text.ToString());
                if (flag == true)
                {
                    Decimal C = A / B;
                    txtConversion.Text = Convert.ToString(C);
                }
                else if (flag == false)
                {
                    Decimal C = D / B;
                    txtConversion.Text = Convert.ToString(C);
                }
            }
            else
            {
                txtConversion.Text = "";
            }
        }
    }
}
