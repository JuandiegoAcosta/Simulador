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
    public partial class Roles : UserControl
    {
        public Roles()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        private static Roles _instance;
        public static Roles instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Roles();
                }

                return _instance;
            }
        }
    }
}
