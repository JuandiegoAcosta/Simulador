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
    public partial class RegistrarChequera : UserControl
    {

        private BLCuenta BLCuenta = new BLCuenta();
        private BLChequeras BLChequeras = new BLChequeras();


        private string modo;
        private CuentasModel gCuenta;
        private ChequerasModel gChequera;
        private string gUsuario;

        public RegistrarChequera(ISession isesion)
        {
            InitializeComponent();
            this.poblarCboTipoCuenta();
            this.poblarCboEstado();
            this.gUsuario = isesion.UserName;

            this.clearForm();
            this.modoInicial();
        }

        private void cuenta2gui(CuentasModel acuenta)
        {
            this.txtCuenta.Text = acuenta.Nrocuenta.ToUpper();
        }

        private ChequerasModel gui2chequera()
        {
            try
            {
                return new ChequerasModel()
                {
                    Id_cuenta = this.gCuenta.Nrocuenta,
                    Fecharegistro = this.dtpFechaRegistro.Value,
                    Cantidad_cheques = (int)this.cboCantidadCheques.SelectedValue,
                    Estado = (string)this.cboEstado.SelectedValue,
                    Inicio = (int)this.nudChequeInicial.Value

                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void poblarCboTipoCuenta()
        {
            SortedDictionary<int, string> userCache = new SortedDictionary<int, string>
                {
                  {50, "050 CHEQUES"},
                  {100, "100 CHEQUES"},
                  {150, "150 CHEQUES"}
                };

            this.cboCantidadCheques.DataSource = new BindingSource(userCache, null);
            this.cboCantidadCheques.ValueMember = "Key";
            this.cboCantidadCheques.DisplayMember = "Value";
            this.cboCantidadCheques.Text = "Elegir una opcion";
        }

        private void poblarCboEstado()
        {
            SortedDictionary<string, string> userCache = new SortedDictionary<string, string>
                {

                  {"EMITIDA", "EMITIDA"},
                  {"EN ESPERA", "EN ESPERA"},
                  {"SOLICITADA", "SOLICITADA"},
                };

            this.cboEstado.DataSource = new BindingSource(userCache, null);
            this.cboEstado.ValueMember = "Key";
            this.cboEstado.DisplayMember = "Value";
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            string cuenta = this.txtCuenta.Text;

            var objeto = this.BLCuenta.cuentaSelectbyNroCuenta(cuenta);

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarCuenta(objeto);
        }

        private void buscarCuenta(List<CuentasModel> objetos)
        {
            string[][] orden = new string[4][];

            orden[0] = new string[] { "NroCuenta", "Numero Cuenta", "150" };
            orden[1] = new string[] { "TipoCuenta", "Tipo Cuenta", "100" };
            orden[2] = new string[] { "SaldoContable", "Saldo Contable", "90" };
            orden[3] = new string[] { "SaldoDisponible", "Saldo Disponible", "90" };

            if (objetos != null)
            {
                using (Ayuda.FormHelp2 formHelp1 = new Ayuda.FormHelp2())
                {
                    formHelp1.setList(objetos, orden);
                    formHelp1.ShowDialog();

                    if (formHelp1.EstaAceptado())
                    {
                        var dato = formHelp1.getObject<CuentasModel>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gCuenta = this.BLCuenta.Getcuenta(dato.Nrocuenta);
                            this.cuenta2gui(this.gCuenta);
                            //this.modoNuevo();
                            //this.modoEdicion();
                        }
                    }
                }
            }
        }

        private void clearForm()
        {
            this.txtCodigo.Text = default(string);
            this.txtCuenta.Text = default(string);
            this.dtpFechaRegistro.Value = DateTime.Now;
            this.cboCantidadCheques.SelectedValue = -1;
            this.cboEstado.SelectedValue = -1;
            this.nudChequeInicial.Value = 0m;

            this.SlblUsuario_creador.Text = "*";
            this.SlblFecha_creacion.Text = "*";
            this.SlblUsuario_modificador.Text = "*";
            this.SlblFecha_modificacion.Text = "*";
        }


        private void modoInicial()
        {
            this.modo = "modoInicial";

            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = true;
            this.buttonCrear.Enabled = false;
            this.buttonDeshacer.Enabled = false;

            this.btnCodigo.Enabled = true;
            this.btnCuenta.Enabled = true;

            this.txtCodigo.Enabled = true;
            this.txtCuenta.Enabled = true;
            this.dtpFechaRegistro.Enabled = false;
            this.cboEstado.Enabled = false;
            this.cboCantidadCheques.Enabled = false;
            this.nudChequeInicial.Enabled = false;
        }

        private void modoNuevo()
        {
            this.modo = "modoNuevo";

            this.buttonActualizar.Enabled = false;
            this.buttonEliminar.Enabled = false;

            this.buttonNuevo.Enabled = false;
            this.buttonCrear.Enabled = true;
            this.buttonDeshacer.Enabled = true;

            this.btnCodigo.Enabled = false;
            this.btnCuenta.Enabled = true;

            this.txtCodigo.Enabled = false;
            this.txtCuenta.Enabled = true;
            this.dtpFechaRegistro.Enabled = true;
            this.cboEstado.Enabled = true;
            this.cboCantidadCheques.Enabled = true;
            this.nudChequeInicial.Enabled = true;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            this.clearForm();
            this.modoNuevo();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2chequera();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedades");
                return;
            }
            if (this.BLChequeras.Insert(objeto))
            {
                this.clearForm();
                this.modoInicial();
                MessageBox.Show("El proceso ha sido correcto");
            }
        }
    }
}
