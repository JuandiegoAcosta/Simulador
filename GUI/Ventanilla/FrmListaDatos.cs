using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Ventanilla
{
    public partial class FrmListaDatos : Form
    {
        public FrmListaDatos()
        {
            InitializeComponent();
        }
        public void CrearLista<T>(List<T> ListaDatos)
        {
            var bindingList = new BindingList<T>(ListaDatos);
            var source = new BindingSource(bindingList, null);
            DGVlistaDatos.DataSource = source;
        }
    }
}
