using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Administrador
{
    public partial class Personas : UserControl
    {
        public Personas()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        private static Personas _instance;
        public static Personas instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Personas();
                }

                return _instance;
            }
        }
    }
}
