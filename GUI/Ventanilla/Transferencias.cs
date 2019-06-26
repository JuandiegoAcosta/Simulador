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
            MessageBox.Show("Operacion Realizada");
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
