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
    public partial class Permisos : UserControl
    {
        public Permisos()
        {
            InitializeComponent();
            this.BackColor = Color.White;
        }

        private static Permisos _instance;
        public static Permisos instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Permisos();
                }

                return _instance;
            }
        }
    }
}
