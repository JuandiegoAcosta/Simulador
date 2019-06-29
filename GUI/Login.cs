using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Variables globales
        public Modelos.Modelos.PersonaModel usuarioLogin;
        public Modelos.Modelos.SucursalModel SucursalUsuario;

        private void button1_Click(object sender, EventArgs e)
        {
            string nick = txtUsuario.Text;
            string pass = txtPass.Text;
            using (WsSistemaBancario.PersonaServiceClient user= new WsSistemaBancario.PersonaServiceClient())
            {
                usuarioLogin = user.Persona_ValidarUsuario(nick, pass);

                if (usuarioLogin != null)
                {
                    VentanaPrincipal x = new VentanaPrincipal();
                    SucursalUsuario = user.Persona_ObtenerSucursal(usuarioLogin.Id);
                    this.LimpiarControles();
                    this.Hide();
                }
                else MessageBox.Show("Credenciales incorrectas");
                //else MessageBox.Show("error");
            }
        }
        private void LimpiarControles()
        {
            this.txtUsuario.Text = "";
            this.txtPass.Text = "";
        }
    }
}
