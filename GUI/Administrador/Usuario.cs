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

namespace Sistema_Bancario.Administrador
{
    public partial class Usuario : UserControl
    {
        public Usuario()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            llenarDGVUsuarios();
            llenarComboBoxRoles();
        }

        private static Usuario _instance;
        public static Usuario instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Usuario();
                }

                return _instance;
            }
        }

        public int id;
        public string nombre;

        public List<PersonaModel> Usuarios;

        private void llenarDGVUsuarios() {


            try
            {

                using (WsSistemaBancario.PersonaServiceClient UsuariosLista = new WsSistemaBancario.PersonaServiceClient())
                {

                    Usuarios = UsuariosLista.Persona_UsuarioSelectAll().ToList();



                    dgvUsuarios.DataSource = Usuarios;


                    dgvUsuarios.Columns["Pass"].Visible = false;
                    dgvUsuarios.Columns["Fechanacimiento"].Visible = false;
                    dgvUsuarios.Columns["Telefono"].Visible = false;
                    dgvUsuarios.Columns["Nrodocumento"].Visible = false;
                    dgvUsuarios.Columns["Tipodocumento"].Visible = false;
                    dgvUsuarios.Columns["Tipo_persona"].Visible = false;
                    dgvUsuarios.Columns["Usuario_creador"].Visible = false;
                    dgvUsuarios.Columns["Fecha_creacion"].Visible = false;
                    dgvUsuarios.Columns["Fecha_modificacion"].Visible = false;
                    dgvUsuarios.Columns["Usuario_modificador"].Visible = false;



                }

            }

            catch (Exception ex)
            {

            }

        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = Convert.ToInt16(dgvUsuarios.Rows[e.RowIndex].Cells["Id"].Value);
                nombre = dgvUsuarios.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();

            }
            pnlPrincipal.SendToBack();
            pnlSecundario.BringToFront();
            llenarDGVRolesUsuario();
        }



        public DataTable rolesUsuario;
        private void llenarDGVRolesUsuario()

        {

            try
            {

                using (WsSistemaBancario.RolesServiceClient RolUsuario = new WsSistemaBancario.RolesServiceClient())
                {

                     rolesUsuario = RolUsuario.Roles_RolesPorPersona(id);

                    dgvRolesUsuario.DataSource = rolesUsuario;

                    //dgvPermisosRol.DataSource = componentesRol;


                    //dgvPermisosRol.Columns["Descripcion"].Visible = false;
                    //dgvPermisosRol.Columns["Codigo"].Visible = false;
                    //dgvPermisosRol.Columns["Id_aplicacion"].Visible = false;
                    //dgvPermisosRol.Columns["Usuario_creador"].Visible = false;
                    //dgvPermisosRol.Columns["IdPadre"].Visible = false;

                    //dgvPermisosRol.Columns["Fecha_creacion"].Visible = false;
                    //dgvPermisosRol.Columns["Fecha_modificacion"].Visible = false;
                    //dgvPermisosRol.Columns["Usuario_modificador"].Visible = false;



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

                using (WsSistemaBancario.RolUsuarioServiceClient RolUsuario = new WsSistemaBancario.RolUsuarioServiceClient())
                {
                    RolUsuarioModel ru = new RolUsuarioModel();
                    ru.Id_persona = id;
                    ru.Id_rol = idRol;
                    ru.Activo = chbRolActivo.Checked;
                    ru.Fecha_creacion = DateTime.Now;
                    ru.Usuario_creador = "Saurom";

                    RolUsuario.RolUsuario_Crear(ru,1);



                    //dgvPermisosRol.DataSource = componentesRol;


                    //dgvPermisosRol.Columns["Descripcion"].Visible = false;
                    //dgvPermisosRol.Columns["Codigo"].Visible = false;
                    //dgvPermisosRol.Columns["Id_aplicacion"].Visible = false;
                    //dgvPermisosRol.Columns["Usuario_creador"].Visible = false;
                    //dgvPermisosRol.Columns["IdPadre"].Visible = false;

                    //dgvPermisosRol.Columns["Fecha_creacion"].Visible = false;
                    //dgvPermisosRol.Columns["Fecha_modificacion"].Visible = false;
                    //dgvPermisosRol.Columns["Usuario_modificador"].Visible = false;
                    llenarDGVRolesUsuario();


                }

            }

            catch (Exception ex)
            {

            }



        }



        public List<RolesModel> roles;

        private void llenarComboBoxRoles()
        {

            try
            {

                using (WsSistemaBancario.RolesServiceClient rol = new WsSistemaBancario.RolesServiceClient())
                {

                    roles = rol.Roles_ObtenerTodos().ToList();


                    cmbRoles.DataSource = roles;

                    cmbRoles.DisplayMember = "Descripcion";
                    //cmbRoles.ValueMember = "Id";




                    //cmbRoles.Items.Add(r.Descripcion);

                }

            }

            catch (Exception ex)
            {

            }

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            pnlSecundario.SendToBack();
            pnlPrincipal.BringToFront();
        }

        public int idRol;

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            RolesModel rm = cmbRoles.SelectedValue as RolesModel;

            idRol = rm.Id;
        }
    }
}
