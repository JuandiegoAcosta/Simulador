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
      private string m_username = null;
      private string m_password = null;
      public Login()
      {
         InitializeComponent();
      }
      //Variables globales
      public Modelos.Modelos.PersonaModel usuarioLogin;
      public Modelos.Modelos.SucursalModel SucursalUsuario;

      private void SetLogin()
      {
         try
         {

            if (!string.IsNullOrEmpty(this.txtUsuario.Text.Trim()))
            { this.m_username = this.txtUsuario.Text.Trim(); }
            else
            { this.m_username = null; }

            if (!string.IsNullOrEmpty(this.txtPass.Text.Trim()))
            { this.m_password = this.txtPass.Text.Trim(); }
            else
            { this.m_password = null; }
         }
         catch (Exception)
         { return; }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         SetLogin();

         using (WsSistemaBancario.PersonaServiceClient user = new WsSistemaBancario.PersonaServiceClient())
         {
            usuarioLogin = user.Persona_ValidarUsuario(this.m_username, this.m_password);

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
