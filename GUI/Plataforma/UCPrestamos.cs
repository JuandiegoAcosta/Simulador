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
    public partial class UCPrestamos : Base
    {
        public UCPrestamos()
        {
            InitializeComponent();
            //se crea el evento click del boton proceder
            proceder1.BTProceder.Click += BTProceder_Click;

        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            //Evento Click del boton proceder
            throw new NotImplementedException();
        }

        private static UCPrestamos _instance;
        public static UCPrestamos instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCPrestamos();
                }

                return _instance;
            }
        }
        private void UCPrestamos_Load(object sender, EventArgs e)
        {

        }
    }
}
