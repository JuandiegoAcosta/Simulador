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
    public partial class CobroGiros :Base
    {
        public CobroGiros()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
           
            GirosMethods girosMethods = new GirosMethods();
            int i = GVCobroGiros.CurrentCell.RowIndex;           
          int executado =  girosMethods.CobrarGiro(Convert.ToInt32(GVCobroGiros[0, i].Value),"Usuario");
            if (executado == 1)
            {
                MessageBox.Show("Giro cobrado");
            }
           
        }

        private static CobroGiros _instance;
        public static CobroGiros instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CobroGiros();
                }

                return _instance;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirosMethods girosMethods = new GirosMethods();          
            var bindingList = new BindingList<object>(girosMethods.SelectGirosbyDocClave(dni1.TBDoi.Text, Convert.ToInt16(clave1.TBClave.Text)));
            var source = new BindingSource(bindingList, null);
            GVCobroGiros.DataSource = source;

        }
    }
}
