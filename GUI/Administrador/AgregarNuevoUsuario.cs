using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Modelos;
using Sistema_Bancario.Clases;

namespace Sistema_Bancario.Administrador
{
    public partial class AgregarNuevoUsuario : Form
    {
        public static int idRol;
        public static int idPersona;
        public static string NombrePersona;

        public AgregarNuevoUsuario()
        {
            
            InitializeComponent();
            
        }

        BuscarPersona f1 = Application.OpenForms.OfType<BuscarPersona>().SingleOrDefault();


        private static AgregarNuevoUsuario _instance;
        public static AgregarNuevoUsuario instance
        {
            get
            {

                if (_instance == null)
                {
                    _instance = new AgregarNuevoUsuario();
                }

                return _instance;
            }
        }


        


        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            using (BuscarPersona frmBuscarPersona = new BuscarPersona())
            {
                frmBuscarPersona.ShowDialog();
                if (frmBuscarPersona.resultado == DialogResult.OK)
                {
                    idPersona = frmBuscarPersona.id;
                    NombrePersona = frmBuscarPersona.nombre;
                    txtUsuarioBuscado.Text = NombrePersona;
                }
            }
            


        }

        bool confirmarCreacion;

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string passEncrypt = Encrypt.GetSHA256(txtContraseña.Text);
                using (WsSistemaBancario.PersonaServiceClient CrearUsuario = new WsSistemaBancario.PersonaServiceClient())
                {
                    //if (chbEstado.Checked == true) {
                    //    estadocheck = true;
                    //}
                    //else { estadocheck =false}



                    confirmarCreacion = CrearUsuario.Persona_CrearNuevoUsuario(idPersona, txtUsuario.Text, passEncrypt, chbEstado.Checked);
                    txtUsuarioBuscado.Text = "";
                    txtContraseña.Text = "";
                    txtUsuario.Text = "";





                    using (WsSistemaBancario.RolUsuarioServiceClient CrearRolUsuario = new WsSistemaBancario.RolUsuarioServiceClient())
                    {

                        RolUsuarioModel rum = new RolUsuarioModel();
                        rum.Id_persona = idPersona;
                        rum.Id_rol = idRol;
                        rum.Activo = true;
                        rum.Fecha_creacion = DateTime.Now;
                        rum.Usuario_creador = "Administrador";

                        CrearRolUsuario.RolUsuario_Crear(rum);
                    }





                    //llenarDGVUsuarios();
                    pnlAgregarUsuario.SendToBack();

                   // pnlSecundario.BringToFront();

                }

            }

            catch (Exception ex)
            {

            }
        }
    }
}
