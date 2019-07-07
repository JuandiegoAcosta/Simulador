using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using CNegocio.Backend;
using System.Windows.Forms;
using Modelos.Modelos;
using CNegocio.Plataforma;

namespace Sistema_Bancario.plataforma_controles
{
    public partial class RegistroPersonaUserControl : UserControl
    {
        public string gusuario { get; set; }

        private BLPersona BLPersona = new BLPersona();
        private TipoDocumentoMethods BLTipo_documento = new TipoDocumentoMethods();
        private persona gPerona;

        public RegistroPersonaUserControl()
        {
            InitializeComponent();
            this.poblarCboTiposDocumento();
            this.poblarCboTipoPersona();
            this.modoInicial();
        }

        private void poblarCboTiposDocumento()
        {
            var datos = this.BLTipo_documento.ObtenerTodos();
            if (datos == null)
                return;

            this.cboTipo_documento.DataSource = this.BLTipo_documento.ObtenerTodos();
            this.cboTipo_documento.ValueMember = "Id_documento";
            this.cboTipo_documento.DisplayMember = "Descripcion";
        }

        private void poblarCboTipoPersona()
        {
            SortedDictionary<string, string> userCache = new SortedDictionary<string, string>
                {
                  {"CLI", "CLIENTE"},
                  {"TRA", "TRABAJADOR"}
                };

            this.cboTipoPersona.DataSource = new BindingSource(userCache, null);
            this.cboTipoPersona.ValueMember = "Key";
            this.cboTipoPersona.DisplayMember = "Value";
        }

        private persona gui2persona()
        {
            try
            {
                string nombres = this.txtNombres.Text;
                string apellidos = this.txtApellidos.Text;
                DateTime fecha_nacimiento = this.dtpFecha_nacimiento.Value;
                int id_tipo_documento = (int)this.cboTipo_documento.SelectedValue;
                string numero_documento = this.txtNumero_documento.Text;
                string correo_electronico = this.txtCorreo.Text;
                bool estado = this.chkEstado.Checked;
                string rol_persona = (string)this.cboTipoPersona.SelectedValue;
                string telefono = this.txtTelefono.Text;

                return new persona()
                {
                    Nombres = nombres,
                    Apellidos = apellidos,
                    Tipodocumento = id_tipo_documento,
                    Correo = correo_electronico,
                    Estado = estado,
                    Fechanacimiento = fecha_nacimiento,
                    Nrodocumento = numero_documento,
                    Usuario_creador = this.gusuario,
                    Fecha_creacion = (DateTime)BLFechaHoraServidor.Obtener(),
                    Tipo_persona = rol_persona,
                    Telefono = telefono

                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void persona2gui(persona apersona)
        {
            this.txtCodigo.Text = apersona.Id.ToString();
            this.txtNombres.Text = apersona.Nombres;
            this.txtApellidos.Text = apersona.Apellidos;
            this.txtNumero_documento.Text = apersona.Nrodocumento;
            this.txtCorreo.Text = apersona.Correo;
            this.txtTelefono.Text = apersona.Telefono;
            this.cboTipo_documento.SelectedValue = apersona.Tipodocumento;
            this.dtpFecha_nacimiento.Value = apersona.Fechanacimiento;
            this.cboTipoPersona.SelectedValue = apersona.Tipo_persona;
            this.chkEstado.Checked = apersona.Estado;

            this.SlblUsuario_creador.Text = apersona.Usuario_creador;
            this.SlblFecha_creacion.Text = apersona.Fecha_creacion.ToString();
            this.SlblUsuario_modificador.Text = apersona.Usuario_modificador;
            this.SlblFecha_modificacion.Text = apersona.Fecha_modificacion.ToString();
        }

        private void clearForm()
        {
            this.txtCodigo.Text = default(string);
            this.txtNombres.Text = default(string);
            this.txtApellidos.Text = default(string);
            this.txtNumero_documento.Text = default(string);
            this.txtCorreo.Text = default(string);
            this.txtTelefono.Text = default(string);
            this.cboTipo_documento.SelectedValue = -1;
            this.cboTipoPersona.SelectedValue = -1;
            this.dtpFecha_nacimiento.Value = DateTime.Now;
            this.chkEstado.Checked =false;

            this.SlblUsuario_creador.Text = "*";
            this.SlblFecha_creacion.Text = "*";
            this.SlblUsuario_modificador.Text = "*";
            this.SlblFecha_modificacion.Text = "*";
        }

        private void modoNuevo()
        {

            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = false;
            this.buttonCrear.Enabled = true;
            this.buttonDeshacer.Enabled = true;

            this.btnCodigo.Enabled = false;
            this.btnNombres.Enabled = false;
            this.btnApellidos.Enabled = false;
            this.btnDocumento.Enabled = false;

            this.txtCodigo.Enabled = false;
            this.txtNombres.Enabled = true;
            this.txtApellidos.Enabled = true;
            this.txtNumero_documento.Enabled = true;
            this.txtCorreo.Enabled = true;
            this.txtTelefono.Enabled = true;
            this.chkEstado.Enabled = true;
            this.cboTipo_documento.Enabled = true;
            this.cboTipoPersona.Enabled = true;
            this.dtpFecha_nacimiento.Enabled = true;
        }

        private void modoInicial()
        {
            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = true;
            this.buttonCrear.Enabled = false;
            this.buttonDeshacer.Enabled = false;

            this.btnCodigo.Enabled = true;
            this.btnNombres.Enabled = true;
            this.btnApellidos.Enabled = true;
            this.btnDocumento.Enabled = true;

            this.txtCodigo.Enabled = true;
            this.txtNombres.Enabled = true;
            this.txtApellidos.Enabled = true;
            this.txtNumero_documento.Enabled = true;
            this.txtCorreo.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.chkEstado.Enabled = false;

            this.cboTipo_documento.Enabled = false;
            this.cboTipoPersona.Enabled = false;
            this.dtpFecha_nacimiento.Enabled = false;
        }

        private void modoEdicion()
        {
            this.buttonCrear.Enabled = false;
            this.buttonActualizar.Enabled = true;
            this.buttonEliminar.Enabled = true;
        }


        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.clearForm();
            this.modoNuevo();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2persona();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }
            if (this.BLPersona.Insert(objeto))
            {
                this.clearForm();
                this.modoInicial();
                MessageBox.Show("El proceso ha sido correcto");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2persona();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }

            objeto.Id = this.gPerona.Id;
            objeto.Usuario_creador = this.gPerona.Usuario_creador;
            objeto.Fecha_creacion = this.gPerona.Fecha_creacion;
            objeto.Usuario_modificador = this.gusuario;
            objeto.Fecha_modificacion = BLFechaHoraServidor.Obtener();

            if (this.BLPersona.Update(objeto))
            {
                MessageBox.Show("El proceso ha sido correcto");
                this.clearForm();
                this.modoInicial();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.gPerona == null)
            {
                MessageBox.Show("Problemas al obtener el objeto de base de datos");
                return;
            }
            if (this.BLPersona.Delete(this.gPerona.Id))
            {
                this.clearForm();
                this.modoInicial();
                MessageBox.Show("El proceso ha sido correcto");
            }
        }

        private void buttonDeshacer_Click(object sender, EventArgs e)
        {

            this.clearForm();
            this.modoInicial();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            string codigo = this.txtCodigo.Text;

            var objeto = this.BLPersona.personaSelectbyID(codigo);

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarObjeto(objeto);
        }

        private void buscarObjeto(List<persona> objetos)
        {
            string[][] orden = new string[2][];

            orden[0] = new string[] { "Id", "Codigo", "100" };
            orden[1] = new string[] { "Nombres", "Nombres", "400" };

            if (objetos != null)
            {
                using (Ayuda.FormHelp2 formHelp1 = new Ayuda.FormHelp2())
                {
                    formHelp1.setList(objetos, orden);
                    formHelp1.ShowDialog();

                    if (formHelp1.EstaAceptado())
                    {
                        var dato = formHelp1.getObject<persona>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gPerona = this.BLPersona.Getpersona(dato.Id);
                            this.persona2gui(this.gPerona);
                            this.modoNuevo();
                            this.modoEdicion();
                        }
                    }
                }
            }
        }

        private void btnNombres_Click(object sender, EventArgs e)
        {
            string nombres = this.txtNombres.Text;

            var objeto = this.BLPersona.personaSelectbyNombres(nombres);

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarObjeto(objeto);
        }

        private void btnApellidos_Click(object sender, EventArgs e)
        {
            string apellidos = this.txtApellidos.Text;

            var objeto = this.BLPersona.personaSelectbyApellidos(apellidos);

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarObjeto(objeto);

        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            string numero_documento = this.txtNumero_documento.Text;

            var objeto = this.BLPersona.personaSelectbyNroDocumento(numero_documento);

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarObjeto(objeto);
        }
    }
}
