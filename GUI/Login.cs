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
                var persona = user.Persona_ValidarUsuario(nick, pass);
                if (persona!=null)
                {
                    MessageBox.Show("credenciales autenticas");
                }else MessageBox.Show("error");
            }
        }


        void Prueba(object sender, EventArgs e)
        {
            Modelos.Modelos.PersonaModel persona = new Modelos.Modelos.PersonaModel()
            {
                Nombreusuario = "Alberto123",
                Pass = "123",
                Correo = "lllamoca@gmail.com",
                Estado = true,
                Nombres = "Alberto",
                Apellidos = "Llamocca Ninaquispe",
                Nrodocumento = "6666",
                Fechanacimiento = Convert.ToDateTime("1997-08-03" ),
                Tipodocumento = 1,
                Fecha_creacion = DateTime.Now,
                Usuario_creador = "Admin"
            };
            CDatos.Manager.PersonaManager cDPersona = new CDatos.Manager.PersonaManager();
            //cDPersona.Insert(persona);
            var per= cDPersona.ValidarUsuario("Alberto123", "123");
            //cDPersona.Delete(per.Id);
            //cDPersona.Update(persona);
            var per2 = cDPersona.PersonaModelSelectAll();
           
        }
    }
}
