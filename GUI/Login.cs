using Modelos.Session;
using Sistema_Bancario.Clases;
using Sistema_Bancario.Config;
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
      #region [ View Config ]
      private const int m_Shadow = 0x0020000;

      protected override CreateParams CreateParams
      {
         get
         {
            CreateParams _cp = base.CreateParams;
            _cp.ClassStyle |= m_Shadow;
            return _cp;
         }
      }

      #endregion

      private string m_username = null;
      private string m_password = null;
      public Login()
      {
         InitializeComponent();
       //  UIButton.SetRound(btnIniciarSesion, 15);
            UIButton.SetRound(Estado, 15);
      //   UIForm.SetRound(this, 7);
      }
      //Variables globales
      private Modelos.Modelos.PersonaModel usuarioLogin;
      private Modelos.Modelos.SucursalModel SucursalUsuario;

      private ISession Session;

      private void SetLogin()
      {
            if (!string.IsNullOrEmpty(this.txtUsuario.Text.Trim()))
                {
                    this.m_username = this.txtUsuario.Text.Trim();
                }
            else
                {
                    MessageBox.Show("No se permite estacios vacios");
                    return;
                }

            if (!string.IsNullOrEmpty(this.txtPass.Text.Trim()))
                {
                    this.m_password = this.txtPass.Text.Trim();
                }
            else
                {
                    MessageBox.Show("No se permite estacios vacios");
                    return;
                }
      }

      private void ClearLogin()
      {
         this.txtUsuario.Text = null;
         this.txtPass.Text = null;
      }

      private bool StartLogin()
      {
         try
         {

            using (WsSistemaBancario.PersonaServiceClient user = new WsSistemaBancario.PersonaServiceClient())
            {
               string passEncrypt = Encrypt.GetSHA256(this.m_password);
               usuarioLogin = user.Persona_ValidarUsuario(this.m_username, passEncrypt);
               SucursalUsuario = user.Persona_ObtenerSucursal(usuarioLogin.Id);
               if (usuarioLogin != null && SucursalUsuario != null)
               {
                  Session = new Session();
                  Session.UserCodigo = usuarioLogin.Id.ToString();
                  Session.UserName = usuarioLogin.Nombreusuario;
                  Session.UserNombreCompleto = usuarioLogin.Nombres + " " + usuarioLogin.Apellidos;

                  //Session.SucursalCodigo = SucursalUsuario.Id.ToString();
                  Session.SucursalCodigo = string.Format("{0:000}", SucursalUsuario.Id);
                  Session.SucursalNombre = SucursalUsuario.Nombre;
                  Session.SucursalUbicacion = SucursalUsuario.Ubicacion;
                  Session.SucursalCodigoBanco = SucursalUsuario.Idbanco.ToString();

                  return true;
               }
                  
            }
            return false;
         }
         catch (Exception ex)
         {
            return false;
         }
      }
      private void button1_Click(object sender, EventArgs e)
      {
            SetLogin();
            if (StartLogin())
            {
                VentanaPrincipal ventanaPrincipal = new VentanaPrincipal(Session);
                ClearLogin();
                Close();
            }
            else MessageBox.Show("Error en las credenciales");
      }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CambiarContraseña cambiarContraseña = new CambiarContraseña();
            cambiarContraseña.Show();
            this.Close();
            
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void BTClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
