using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNegocio.Plataforma;
using Modelos.Modelos;
using Modelos.Session;

namespace Sistema_Bancario.plataforma_controles
{
    public partial class NuevaTarjeta : UserControl
    {

        private BLTarjeta BLTarjeta = new BLTarjeta();


        private TarjetaModel gtarjeta;
        private string gUsuario;

        public NuevaTarjeta(ISession isesion)
        {
            InitializeComponent();

            this.gUsuario = isesion.UserName;


            this.clearForm();
            this.modoInicial();
        }

        private TarjetaModel gui2tarjeta()
        {
            try
            {
                return new TarjetaModel()
                {
                    Codcontrol = Convert.ToInt32(this.txtCodigoControl.Text),
                    Password = Convert.ToInt32(this.txtPassword.Text),
                    Fechavencimiento = this.dtpFechaVencimiento.Value,
                    Estado = this.chkEstado.Checked,
                    Usuario_creador = this.gUsuario,
                    Fecha_creacion = (DateTime)BLFechaHoraServidor.Obtener()
                };

            }
            catch (Exception)
            {
                return null;
            }
        }

        private void tarjeta2gui(TarjetaModel atarjeta)
        {
            this.txtCodigo.Text = atarjeta.Numero.ToString();
            this.txtCodigoControl.Text = atarjeta.Codcontrol.ToString();
            this.txtPassword.Text = atarjeta.Password.ToString();
            this.dtpFechaVencimiento.Value = (DateTime)atarjeta.Fechavencimiento;
            this.chkEstado.Checked = atarjeta.Estado;
        }


        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.clearForm();
            this.modoNuevo();
        }


        private void clearForm()
        {
            this.txtCodigo.Text = default(string);
            this.txtCodigoControl.Text = default(string);
            this.txtPassword.Text = default(string);
            this.dtpFechaVencimiento.Value = DateTime.Now;
            this.chkEstado.Checked = false;

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

            this.txtCodigo.Enabled = false;
            this.txtCodigoControl.Enabled = true;
            this.txtPassword.Enabled = true;
            this.dtpFechaVencimiento.Enabled = true;
            this.chkEstado.Enabled = true;
            this.chkEstado.Enabled = true;
        }

        private void modoInicial()
        {
            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = true;
            this.buttonCrear.Enabled = false;
            this.buttonDeshacer.Enabled = false;

            this.btnCodigo.Enabled = true;

            this.txtCodigo.Enabled = true;
            this.dtpFechaVencimiento.Enabled = false;
            this.txtCodigoControl.Enabled = false;
            this.txtPassword.Enabled = false;
            this.chkEstado.Enabled = false;
        }

        private void modoEdicion()
        {
            this.buttonCrear.Enabled = false;
            this.buttonActualizar.Enabled = true;
            this.buttonEliminar.Enabled = true;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2tarjeta();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }
            if (this.BLTarjeta.Insert(objeto))
            {
                this.clearForm();
                this.modoInicial();
                MessageBox.Show("El proceso ha sido correcto");
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2tarjeta();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }

            objeto.Numero = this.gtarjeta.Numero;
            objeto.Usuario_creador = this.gtarjeta.Usuario_creador;
            objeto.Fecha_creacion = this.gtarjeta.Fecha_creacion;
            objeto.Usuario_modificador = this.gUsuario;
            objeto.Fecha_modificacion = BLFechaHoraServidor.Obtener();

            if (this.BLTarjeta.Update(objeto))
            {
                MessageBox.Show("El proceso ha sido correcto");
                this.clearForm();
                this.modoInicial();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.gtarjeta == null)
            {
                MessageBox.Show("Problemas al obtener el objeto de base de datos");
                return;
            }
            if (this.BLTarjeta.Delete(this.gtarjeta.Numero))
            {
                this.clearForm();
                this.modoInicial();

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

            var objeto = this.BLTarjeta.tarjetaSelectbyId(codigo);

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarTarjetas(objeto);
        }

        private void buscarTarjetas(List<TarjetaModel> objetos)
        {
            string[][] orden = new string[3][];

            orden[0] = new string[] { "Numero", "Codigo", "100" };
            orden[1] = new string[] { "Fechavencimiento", "Fecha Vencimiento", "150" };
            orden[2] = new string[] { "FechaVinculacion", "Fecha Vinculacion", "150" };

            if (objetos != null)
            {
                using (Ayuda.FormHelp2 formHelp1 = new Ayuda.FormHelp2())
                {
                    formHelp1.setList(objetos, orden);
                    formHelp1.ShowDialog();

                    if (formHelp1.EstaAceptado())
                    {
                        var dato = formHelp1.getObject<TarjetaModel>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gtarjeta = this.BLTarjeta.Gettarjeta(dato.Numero);
                            this.tarjeta2gui(this.gtarjeta);
                            this.modoNuevo();
                            this.modoEdicion();
                        }
                    }
                }
            }
        }
    }
}
