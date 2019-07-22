using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Bancario.plataforma_controles;
using Modelos.Session;
using XWFControlLibrary.Ventanilla;

namespace Sistema_Bancario
{
    public partial class Pruebas : Form
    {
       
        public Pruebas()
        {
            InitializeComponent();
         ViewTipoCambio v = new ViewTipoCambio();
         this.Controls.Add(v);
        }

    }
}
