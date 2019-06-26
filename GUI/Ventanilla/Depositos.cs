using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Depositos : Sistema_Bancario.Base
    {
        public Depositos()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operacion Realizada");
        }

        private static Depositos _instance;
        public static Depositos instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Depositos();
                }

                return _instance;
            }
        }
    }
}
