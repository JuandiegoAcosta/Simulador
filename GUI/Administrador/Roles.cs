using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos.Modelos;

namespace Sistema_Bancario.Administrador
{
    public partial class Roles : UserControl
    {
        public Roles()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            //pnlPrincipal.BringToFront();
            //pnlAgregarUsuario.SendToBack();
            //pnlSecundario.SendToBack();
            cargarDGV();
        }

        private static Roles _instance;
        public static Roles instance
        {
            get
            {

                if (_instance == null)
                {
                    _instance = new Roles();
                }

                return _instance;
            }
        }


        public List<RolesModel> roles;

        private void cargarDGV()
        {

            try
            {

                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {
                    roles = rol.Roles_ObtenerTodos().ToList();


                    

                    dgvRoles.DataSource = roles;

                    dgvRoles.Columns["Fecha_modificacion"].Visible = false;
                    dgvRoles.Columns["Usuario_creador"].Visible = false;
                    dgvRoles.Columns["Usuario_modificador"].Visible = false;
                }

            }

            catch (Exception ex)
            {

            }
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            try
            {

                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {
                    RolesModel objectmodelo = new RolesModel();

                    objectmodelo.Descripcion = txtRol.Text;
                    objectmodelo.Fecha_creacion = DateTime.Now;
                    objectmodelo.Usuario_creador = "Miau";
                    //objectmodelo.Fecha_modificacion = DateTime.Now;

                    //objectmodelo.Usuario_modificador = "";


                    rol.Roles_Crear(objectmodelo);


                    cargarDGV();






                }

            }

            catch (Exception ex)
            {

            }
        }

        private static string nombreRol;
        private static int idRol;

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtRol.Text = dgvRoles.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();

                nombreRol = dgvRoles.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                idRol = Convert.ToInt16(dgvRoles.Rows[e.RowIndex].Cells["Id"].Value);

                

            }
        }


        public List<PersonaModel> usuarios;

        private void llenarDGVUsuarios()

        {

            try
            {

                using (WsSistemaBancario.PersonaServiceClient UsuariosRol = new WsSistemaBancario.PersonaServiceClient())
                {




                    usuarios = UsuariosRol.GetPersonasPorRol(idRol).ToList();



                    dgvUsuarios.DataSource = usuarios;

                    dgvUsuarios.Columns["Nombres"].DisplayIndex = 2;
                    dgvUsuarios.Columns["Nombreusuario"].DisplayIndex = 3;
                    dgvUsuarios.Columns["Correo"].DisplayIndex = 4;
                    dgvUsuarios.Columns["Nrodocumento"].DisplayIndex = 5;
                    dgvUsuarios.Columns["Estado"].DisplayIndex = 8;

                    dgvUsuarios.Columns["Id"].Visible = false;
                    dgvUsuarios.Columns["Pass"].Visible = false;
                    dgvUsuarios.Columns["Apellidos"].Visible = false;
                    dgvUsuarios.Columns["Fechanacimiento"].Visible = false;
                    dgvUsuarios.Columns["Telefono"].Visible = false;
                    dgvUsuarios.Columns["Tipodocumento"].Visible = false;
                    dgvUsuarios.Columns["Fecha_creacion"].Visible = false;
                    dgvUsuarios.Columns["Fecha_modificacion"].Visible = false;
                    dgvUsuarios.Columns["Usuario_creador"].Visible = false;
                    dgvUsuarios.Columns["Usuario_modificador"].Visible = false;
                    dgvUsuarios.Columns["Tipo_persona"].Visible = false;

                }

            }

            catch (Exception ex)
            {

            }



        }




        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            try
            {

                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {
                    RolesModel objectmodelo = new RolesModel();
                    objectmodelo.Id = idRol;
                    objectmodelo.Descripcion = txtRol.Text;
                    objectmodelo.Fecha_modificacion = DateTime.Now;
                    objectmodelo.Usuario_modificador = "";
                    rol.Roles_Editar(objectmodelo);

                    cargarDGV();
                }

            }

            catch (Exception ex)
            {

            }

        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            try
            {

                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {

                    rol.Roles_Eliminar(idRol);
                    cargarDGV();

                }

            }

            catch (Exception ex)
            {

            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            pnlSecundario.SendToBack();
            pnlPrincipal.BringToFront();
        }

        private void dgvRoles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlPrincipal.SendToBack();
            pnlAgregarUsuario.SendToBack();
            pnlBusquedaPersona.SendToBack();
            pnlSecundario.BringToFront();

            llenarDGVUsuarios();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            pnlPrincipal.SendToBack();
            pnlSecundario.SendToBack();
            pnlAgregarUsuario.BringToFront();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAgregarUsuario.SendToBack();
            pnlSecundario.BringToFront();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            pnlAgregarUsuario.SendToBack();
            pnlBusquedaPersona.BringToFront();
        }

        private void btnBuscarEnBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            pnlBusquedaPersona.SendToBack();
            pnlAgregarUsuario.BringToFront();
            pnlPrincipal.SendToBack();
            pnlSecundario.SendToBack();
        }
    }
}
