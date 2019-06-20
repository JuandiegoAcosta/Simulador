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
    public partial class UCactualizarCuenta : UserControl
    {
        public UCactualizarCuenta()
        {
            InitializeComponent();
        }

        private void UCactualizarCuenta_Load(object sender, EventArgs e)
        {

        }

        private static UCactualizarCuenta _instance;
        public static UCactualizarCuenta instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCactualizarCuenta();
                }

                return _instance;
            }
        }
    }
}
