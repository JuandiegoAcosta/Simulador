using CNegocio.Ventanilla;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Transferencias : Base
    {
        public Transferencias()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
            
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            TransferenciasMethods transferencias = new TransferenciasMethods();
            var CuentasTrajetas = new CuentasTarjetasModel();
            CuentasTrajetas.Monto = Convert.ToDecimal(txtMonto.Text);
            CuentasTrajetas.NroCuenta = Convert.ToInt32(txtNroCuentaOrigen.Text);
            CuentasTrajetas.NroCuentaDestino = Convert.ToInt32(txtNroCuentaDestino.Text);
            CuentasTrajetas.doi = Convert.ToInt32(doi1.TBDoi.Text);
            CuentasTrajetas.clave = Convert.ToInt32(clave1.TBClave.Text);
            if (transferencias.RealizarTransferencia(CuentasTrajetas) > 1)
            {
                MessageBox.Show("Operacion Realizada");
            }
           
        }

        private static Transferencias _instance;
        public static Transferencias instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transferencias();
                }

                return _instance;
            }
        }
    }
}
