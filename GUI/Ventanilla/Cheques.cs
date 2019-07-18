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

         if (string.IsNullOrEmpty(TBNroCheque.Text.Trim()))
            return;
         if (string.IsNullOrEmpty(monto1.TBMonto.Text))
            return;
         if (string.IsNullOrEmpty(dni2.TBDni.Text))
            return;
         if (string.IsNullOrEmpty(nroCuenta1.TBNroCuenta.Text))
            return;

            CobroChequeMethods cobroCheque = new CobroChequeMethods();
            ChequeModel cheque = new ChequeModel();
            StatusStrip o = this.TopLevelControl.Controls.Find("stStatus", true).FirstOrDefault() as StatusStrip;
            cheque.Numero = Convert.ToInt32(TBNroCheque.Text);
            cheque.Monto = Convert.ToInt32(monto1.TBMonto.Text);
            cheque.Usuario_creacion = o.Items[1].Text;
            cheque.DOI = dni2.TBDni.Text;
                        
            string result = cobroCheque.CobroInsert(cheque, nroCuenta1.TBNroCuenta.Text);
            MessageBox.Show(result);
            //if( result.Equals("-1"))
            //{
            //    MessageBox.Show("Se encontro el cheque y se hizo el retiro");
            //}
            //else if (result == "0")
            //{
            //    MessageBox.Show("Cheque retirado o no Encontrado");
            //}else
            //{
            //    MessageBox.Show("Error");
            //};
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
