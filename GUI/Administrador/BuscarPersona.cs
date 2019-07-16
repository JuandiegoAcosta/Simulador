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
    public partial class BuscarPersona : Form
    {
        public BuscarPersona()
        {
            InitializeComponent();
            llenarBusquedaUsuariosDGV();
        }

        public List<PersonaModel> usuariosFiltrados;

        public int id;
        public string nombre;
        public string usuario;


        // AgregarNuevoUsuario f1 = Application.OpenForms.OfType<AgregarNuevoUsuario>().SingleOrDefault();



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
                    //dgvBusquedaUsuarios.Columns["NombreUsuario"].Visible = false;
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

        private void dgvBusquedaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                id = Convert.ToInt16(dgvBusquedaUsuarios.Rows[e.RowIndex].Cells["Id"].Value);
                nombre= dgvBusquedaUsuarios.Rows[e.RowIndex].Cells["Nombres"].Value.ToString();
                usuario = dgvBusquedaUsuarios.Rows[e.RowIndex].Cells["NombreUsuario"].Value.ToString();

            }
        }

        PersonaModel persona = new PersonaModel();
        public DialogResult resultado;
        private void btnAceptarBusqueda_Click(object sender, EventArgs e)
        {
            resultado = DialogResult.OK;
            this.Close();
        }

        private void btnCancelarBusqueda_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
