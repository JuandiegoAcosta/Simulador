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
    public partial class Retiros : Sistema_Bancario.Base
    {
        public Retiros()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
            
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            RetirosMethods retirosMethods = new RetirosMethods();
            retirosMethods.InsertaRetiro
                (Convert.ToDecimal(monto1.TBMonto.Text),
                Convert.ToInt32(nro_Tarjeta1.TBNroTarjeta.Text),
                Convert.ToInt32(clave1.TBClave.Text));

            MessageBox.Show("Retiro con exito");
        }

    

        private static Retiros _instance;
        public static Retiros instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Retiros();
                }

                return _instance;
            }
        }
    }
}
