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

        private void button1_Click(object sender, EventArgs e)
        {
            string nick = txtUsuario.Text;
            string pass = txtPass.Text;
            using (WsSistemaBancario.PersonaServiceClient user= new WsSistemaBancario.PersonaServiceClient())
            {
                //var persona = user.Persona_ValidarUsuario(nick, pass);

                VentanaPrincipal x = new VentanaPrincipal();
                if (user.Persona_ValidarUsuario(nick, pass) != null)
                {
                   

                }else MessageBox.Show("error");
            }
        }
    }
}
