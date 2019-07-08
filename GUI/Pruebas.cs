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

namespace Sistema_Bancario
{
    public partial class Pruebas : Form
    {
        ISession sesion;
        NuevaCuentaUserControl cuenta;

        public Pruebas()
        {
            InitializeComponent();

            sesion = new Session()
            {
                SucursalCodigo = "002",
                SucursalNombre = "Arequipa",
                SucursalCodigoBanco = "1",
                UserCodigo = "8",
                SucursalUbicacion = "Arequipa",
                UserName = "clay",
                UserNombreCompleto = "AAAAAAAA"
            };

            cuenta = new NuevaCuentaUserControl(sesion);
            this.Controls.Add(cuenta);
        }

        

        private void Pruebas_Load(object sender, EventArgs e)
        {
             
        }
    }
}
