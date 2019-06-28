using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Plataforma
{
    public partial class UCCliente : Base
    {
        public UCCliente()
        {
            InitializeComponent();
            //proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void UCCliente_Load(object sender, EventArgs e)
        {

        }

        private void BTProceder_Click(object sender, EventArgs e)
        {

            //Evento Click del boton proceder
            throw new NotImplementedException();
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
    }
}
