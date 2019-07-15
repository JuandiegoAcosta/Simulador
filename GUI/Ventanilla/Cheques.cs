using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio.Ventanilla;
using Modelos.Modelos;

namespace Sistema_Bancario.Ventanilla
{
    public partial class Cheques : Base
    {
        public Cheques()
        {
            InitializeComponent();
            nroCuenta1.Visible = false;
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            CobroChequeMethods cobroCheque = new CobroChequeMethods();
            ChequeModel cheque = new ChequeModel();
            cheque.Numero = Convert.ToInt32(TBNroCheque.Text);
            cheque.Monto = Convert.ToInt32(monto1.TBMonto.Text);

            cobroCheque.CobroInsert(cheque, nroCuenta1.TBNroCuenta.Text);
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
