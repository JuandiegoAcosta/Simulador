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
using Sistema_Bancario.Clases;
using System.ServiceModel.Channels;
using Modelos.Session;

namespace Sistema_Bancario.Administrador
{
    public partial class Roles : UserControl
    {
        Modelos.Session.ISession session = new Session();
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
                    //objectmodelo.Fecha_creacion = DateTime.Now;
                    //objectmodelo.Usuario_creador = "Miau";
                    //objectmodelo.Fecha_modificacion = DateTime.Now;

                    //objectmodelo.Usuario_modificador = "";


                    rol.Roles_Crear(objectmodelo,1);


                    cargarDGV();






                }

            }

            catch (Exception ex)
            {

            }
        }

        public static string nombreRol;
        public static int idRol;

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtRol.Text = dgvRoles.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();

                nombreRol = dgvRoles.Rows[e.RowIndex].Cells["Descripcion"].Value.ToString();
                idRol = Convert.ToInt16(dgvRoles.Rows[e.RowIndex].Cells["Id"].Value);

                

            }
            llenarDGVPermisosRol();
        }


        public DataTable usuarios;

        private void llenarDGVUsuarios()

        {

            try
            {

                using (WsSistemaBancario.PersonaServiceClient UsuariosRol = new WsSistemaBancario.PersonaServiceClient())
                {


                    //dgvUsuarios.AutoGenerateColumns = false;

                    usuarios = UsuariosRol.GetPersonasPorRol(idRol);

                    

                    dgvUsuarios.DataSource = usuarios;

                    //dgvUsuarios.AutoGenerateColumns = false;


                    dgvUsuarios.CurrentCell = null;


                    //dgvUsuarios.Columns["CustomerID"].Visible = false;


                    dgvUsuarios.Columns["Id"].DataPropertyName = "Id";

                    //dgvUsuarios.Columns["Id"].DataPropertyName = "Id";

                    dgvUsuarios.Columns["IDPersona"].DataPropertyName = "IDPersona";

                    dgvUsuarios.Columns["Nombres"].DataPropertyName = "Nombres";
                    //dgvUsuarios.Columns["Nombres"].DisplayIndex = 2;

                    dgvUsuarios.Columns["Nombreusuario"].DataPropertyName = "Nombreusuario";
                    //dgvUsuarios.Columns["Nombreusuario"].DisplayIndex = 3;


                    //dgvUsuarios.Columns["Correo"].DisplayIndex = 4;
                    //dgvUsuarios.Columns["Nrodocumento"].DataPropertyName = "Nrodocumento";
                    //dgvUsuarios.Columns["Nrodocumento"].DisplayIndex = 5;


                    dgvUsuarios.Columns["Estado"].DataPropertyName = "Estado";
                    //dgvUsuarios.Columns["Estado"].DisplayIndex = 8;

                    DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();
                    btnEditar.Name = "Editar";
                    btnEditar.HeaderText = "Editar";
                    dgvUsuarios.Columns.Add(btnEditar);

                    //dgvUsuarios.Columns["Editar"].DisplayIndex = 5;

                    DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
                    btnEliminar.Name = "Edliminar";
                    btnEliminar.HeaderText = "Eliminar";
                    dgvUsuarios.Columns.Add(btnEliminar);



                    dgvUsuarios.Columns["Id"].Visible = false;
                    dgvUsuarios.Columns["IDPersona"].Visible = false;

                    dgvUsuarios.Columns["Correo"].Visible = false;
                    dgvUsuarios.Columns["NroDocumento"].Visible = false;
                
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
                    rol.Roles_Editar(objectmodelo,1);

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
            //AgregarNuevoUsuario frmAgregarNuevoUsuario = new AgregarNuevoUsuario();
            //frmAgregarNuevoUsuario.Show();


            pnlPrincipal.SendToBack();
            pnlSecundario.SendToBack();
            pnlAgregarUsuario.BringToFront();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlAgregarUsuario.SendToBack();
            pnlSecundario.BringToFront();
        }


        public static string NombrePersona;

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {

            using (BuscarPersona frmBuscarPersona = new BuscarPersona())
            {
                frmBuscarPersona.ShowDialog();
                if (frmBuscarPersona.resultado == DialogResult.OK)
                {
                    idPersona = frmBuscarPersona.id;
                    usuarioPersona = frmBuscarPersona.usuario;
                    txtNombrePersona.Text = usuarioPersona;
                    
                    NombrePersona = frmBuscarPersona.nombre;
                    txtUsuarioBuscado.Text = NombrePersona;
                }
            }




            //BuscarPersona bp = new BuscarPersona();
            //bp.Show();

            ////pnlAgregarUsuario.SendToBack();
            pnlBusquedaPersona.BringToFront();
        }



        public List<PersonaModel> usuariosFiltrados;

        private void btnBuscarEnBusqueda_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusquedaNombres.Text) && !string.IsNullOrEmpty(txtBusquedaApellidos.Text))
            {
                llenarBusquedaUsuariosDGV();
            }
            else
            {
                llenarBusquedaUsuariosDGV();
            }
        }

        private void llenarBusquedaUsuariosDGV()
        {

            try
            {

                using (WsSistemaBancario.PersonaServiceClient buscarPersonaNombresApellidos = new WsSistemaBancario.PersonaServiceClient())
                {
                    usuariosFiltrados = buscarPersonaNombresApellidos.Persona_GetPersonaNombreApellidos(txtBusquedaNombres.Text, txtBusquedaApellidos.Text).ToList();

                    dgvBusquedaUsuarios.DataSource = usuariosFiltrados;
                    //usuariosFiltrados = null;

                    dgvBusquedaUsuarios.Columns["Nombres"].DisplayIndex = 1;
                    dgvBusquedaUsuarios.Columns["Apellidos"].DisplayIndex = 2;
                    dgvBusquedaUsuarios.Columns["NroDocumento"].DisplayIndex = 3;

                    dgvBusquedaUsuarios.Columns[6].HeaderText = "Tipo Documento";


                    //dgvBusquedaUsuarios.Columns["Id"].Visible = false;
                    dgvBusquedaUsuarios.Columns["NombreUsuario"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Pass"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Fechanacimiento"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Telefono"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Tipodocumento"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Correo"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Fecha_creacion"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Fecha_modificacion"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Usuario_creador"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Usuario_modificador"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Tipo_persona"].Visible = false;
                    dgvBusquedaUsuarios.Columns["Estado"].Visible = false;



                }

            }

            catch (Exception ex)
            {

            }

        }



        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            pnlBusquedaPersona.SendToBack();
            pnlAgregarUsuario.BringToFront();
            pnlPrincipal.SendToBack();
            pnlSecundario.SendToBack();
        }

        
        private static int idPersona;
        private static string usuarioPersona;

        private void dgvBusquedaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idPersona = Convert.ToInt16(dgvBusquedaUsuarios.Rows[e.RowIndex].Cells["Id"].Value);
                usuarioPersona = (dgvBusquedaUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value).ToString();

            }
        }


        PersonaModel persona = new PersonaModel();

        private void btnAceptarBusqueda_Click(object sender, EventArgs e)
        {
            pnlAgregarUsuario.BringToFront();
            pnlBusquedaPersona.SendToBack();
            txtBusquedaNombres.Text = "";
            txtBusquedaApellidos.Text = "";




            try
            {

                using (WsSistemaBancario.PersonaServiceClient ObtenerPersona = new WsSistemaBancario.PersonaServiceClient())
                {


                    persona = ObtenerPersona.Persona_ObtenerUno(idPersona);
                    txtUsuarioBuscado.Text = persona.Nombres;

                }

            }

            catch (Exception ex)
            {

            }



        }

        bool confirmarCreacion;
        bool estadocheck;

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                //string passEncrypt = Encrypt.GetSHA256(txtContraseña.Text);
                





                    using (WsSistemaBancario.RolUsuarioServiceClient CrearRolUsuario = new WsSistemaBancario.RolUsuarioServiceClient())
                    {

                        RolUsuarioModel rum = new RolUsuarioModel();
                        rum.Id_persona = idPersona;
                        rum.Id_rol = idRol;
                        rum.Activo = chbEstado.Checked;
;
                        rum.Usuario_creador = "Administrador";

                        CrearRolUsuario.RolUsuario_Crear(rum,1);
                    }





                        llenarDGVUsuarios();
                    pnlAgregarUsuario.SendToBack();
                    
                    pnlSecundario.BringToFront();

                

            }

            catch (Exception ex)
            {

            }
        }


        public List<ComponenteModel> componentesRol;

        private void llenarDGVPermisosRol()

        {

            try
            {

                using (WsSistemaBancario.ComponenteServiceClient  PermisosPorRol= new WsSistemaBancario.ComponenteServiceClient())
                {

                    componentesRol = PermisosPorRol.Componente_ObtenerComponentesRol(idRol).ToList();



                    dgvPermisosRol.DataSource = componentesRol;


                     dgvPermisosRol.Columns["Descripcion"].Visible = false;
                     dgvPermisosRol.Columns["Codigo"].Visible = false;
                     dgvPermisosRol.Columns["Id_aplicacion"].Visible = false;
                     dgvPermisosRol.Columns["Usuario_creador"].Visible = false;
                     dgvPermisosRol.Columns["IdPadre"].Visible = false;
                     
                     dgvPermisosRol.Columns["Fecha_creacion"].Visible = false;
                     dgvPermisosRol.Columns["Fecha_modificacion"].Visible = false;
                    dgvPermisosRol.Columns["Usuario_modificador"].Visible = false;
                    


                }

            }

            catch (Exception ex)
            {

            }



        }

        public int idUsuario;
        public int idRolUsuario;
        public string nombreusuario;

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                var senderGrid = (DataGridView)sender;


                idRolUsuario = (int)(dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value);
                idUsuario = Convert.ToInt16(dgvUsuarios.Rows[e.RowIndex].Cells["IdPersona"].Value);
                nombreusuario = dgvUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();


                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    ///////////using

                    if (e.ColumnIndex==5) {
                        Editar frmeditar = new Editar();

                        frmeditar.txtUsuarioEditar.Text = nombreusuario;
                        frmeditar.txtIdUsuario.Text = idUsuario.ToString();
                        frmeditar.idRolUsuario.Text = idRolUsuario.ToString();
                        frmeditar.btnEditar.Visible = true;
                        frmeditar.Show();

                    }

                    if (e.ColumnIndex == 6)
                    {
                        Editar frmeditar = new Editar();

                        frmeditar.txtUsuarioEditar.Text = nombreusuario;
                        frmeditar.txtIdUsuario.Text = idUsuario.ToString();
                        frmeditar.idRolUsuario.Text = idRolUsuario.ToString();
                        frmeditar.btnEliminar.Visible = true;
                        frmeditar.Show();

                    }




                }
            }
        }
    }
}
