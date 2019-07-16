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
        //NuevoPrestamoUserControl prestamo;
        //NuevaTarjeta tarjeta;
        //NuevaCuentaUserControl cuenta;
        RegistroPersonaUserControl persona;

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

            //prestamo = new NuevoPrestamoUserControl(sesion);
            //tarjeta = new NuevaTarjeta(sesion);
            //cuenta = new NuevaCuentaUserControl(sesion);
            persona = new RegistroPersonaUserControl(sesion);

            this.Controls.Add(persona);
        }

    }
}
