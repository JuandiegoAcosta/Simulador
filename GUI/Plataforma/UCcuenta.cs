using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Session;
using Modelos.Modelos;

namespace Sistema_Bancario.Plataforma
{
    public partial class UCcuenta : Base
    {
        public ISession Session; 
        private PersonaModel cliente;
        private TipoMonedaModel moneda;
        private string tipoCuenta;

        public UCcuenta()
        {
            InitializeComponent();
            //se crea el evento click del boton proceder
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            //Evento Click del boton proceder
            //Comprobaciones
            if (Session == null) { MessageBox.Show("La sesión ha expirado"); this.Dispose(); }

            cliente = datosPersona1.ObtenerPersona();

            if (cliente == null) { MessageBox.Show("Selecciona un cliente"); }
            if (moneda == null) { MessageBox.Show("Selecciona una moneda"); return; }
            if (string.IsNullOrEmpty(tipoCuenta)) { MessageBox.Show("Selecciona un tipo de cuenta"); return; }
        }

        private static UCcuenta _instance;
        public static UCcuenta instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCcuenta();
                }

                return _instance;
            }
        }
            
        private void UCcuenta_Load(object sender, EventArgs e)
        {
            //pruebalo aver, espera te muestro donde se implementa 
        }
    }
}
