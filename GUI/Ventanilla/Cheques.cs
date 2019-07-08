using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Ventanilla
{
    public partial class Cheques : Base
    {
        public Cheques()
        {
            InitializeComponent();
            nroCuenta1.Visible = false;
        }
        private static Cheques _instance;
        public static Cheques instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Cheques();
                }

                return _instance;
            }
        }

        private void CKDeposito_CheckedChanged(object sender, EventArgs e)
        {
            if (CKDeposito.Checked)
            {
                nroCuenta1.Visible = true;
            }
            else
            {
                nroCuenta1.Visible = false;
            }
            
        }
    }
}
