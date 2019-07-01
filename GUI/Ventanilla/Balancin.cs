using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Bancario.Clases;

namespace Sistema_Bancario.Ventanilla
{
    public partial class Balancin : UserControl
    {

        public Balancin()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            this.CargarComboMoneda();
        }
        private static Balancin _instance;
        public static Balancin instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Balancin();
                }

                return _instance;
            }
        }

        private void cmbMonedas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbMonedas.SelectedIndex==0)
            {
                this.CmbDenominaciones.DataSource = null;
                this.CmbDenominaciones.DataSource =Denominaciones.Instance.soles;
            }else if(cmbMonedas.SelectedIndex==1)
            {
                this.CmbDenominaciones.DataSource = null;
                this.CmbDenominaciones.DataSource = Denominaciones.Instance.dolares;
            }
        }
        private void CargarComboMoneda()
        {
            using (WsSistemaBancario.TipoMonedaServiceClient moneda=new WsSistemaBancario.TipoMonedaServiceClient())
            {
                cmbMonedas.DataSource = moneda.Moneda_ObtenerTodos();
                cmbMonedas.DisplayMember = "Nombre";
            }
        }
    }
}
