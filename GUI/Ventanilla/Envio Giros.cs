using CNegocio.Ventanilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Envio_Giros : Sistema_Bancario.Base
    {
        public Envio_Giros()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            GirosMethods methods = new GirosMethods();
            if (methods.EnviarGiro(Convert.ToDouble(monto1.TBMonto.Text),
                Convert.ToInt32(clave1.TBClave.Text),
                Convert.ToInt32(dni1.TBDni.Text),
                Convert.ToInt32(dni2.TBDni.Text)) == true)
            {
                MessageBox.Show("Giro Enviado");
            }
        }

        private static Envio_Giros _instance;
        public static Envio_Giros instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Envio_Giros();
                }

                return _instance;
            }
        }
    }
}
