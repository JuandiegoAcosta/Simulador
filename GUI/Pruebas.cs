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
using XWFControlLibrary.UI.help;

namespace Sistema_Bancario
{
    public partial class Pruebas : Form
    {
       
        public Pruebas()
        {
            InitializeComponent();
  
        }

      private void Button1_Click(object sender, EventArgs e)
      {
         FormReport t = new FormReport();
         if (t.ShowDialog() == DialogResult.OK)
         {
            //textBox1.Text  = t.Conversion.ToString();
         }
      }
   }
}
