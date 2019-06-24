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
    public partial class Balancin : UserControl
    {
        public Balancin()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }
        private static Balancin _instance;
        public static Balancin instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Balancin();
                }

                return _instance;
            }
        }
    }
}
