using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bancario.Controles
{
    //el combo tiene que buscar en la bd el tipo de moneda
    public partial class TipoMoneda : UserControl
    {
        public TipoMoneda()
        {
            InitializeComponent();
        }

        private void TipoMoneda_Load(object sender, EventArgs e)
        {

        }

        private void PoblarCbxMonedas()
        {
            //using (WsSistemaBancario user = new WsSistemaBancario.PersonaServiceClient())
            //{
            //    usuarioLogin = user.Persona_ValidarUsuario(this.m_username, this.m_password);
            //    SucursalUsuario = user.Persona_ObtenerSucursal(usuarioLogin.Id);
            //    if (usuarioLogin != null && SucursalUsuario != null)
            //    {
            //        Session = new Session();
            //        Session.UserCodigo = usuarioLogin.Id.ToString();
            //        Session.UserName = usuarioLogin.Nombreusuario;
            //        Session.UserNombreCompleto = usuarioLogin.Nombres;

            //        Session.SucursalCodigo = SucursalUsuario.Id.ToString();
            //        Session.SucursalNombre = SucursalUsuario.Nombre;
            //        Session.SucursalUbicacion = SucursalUsuario.Ubicacion;
            //        Session.SucursalCodigoBanco = SucursalUsuario.Idbanco.ToString();

            //        return true;
            //    }

            //}
        }

    }
}
