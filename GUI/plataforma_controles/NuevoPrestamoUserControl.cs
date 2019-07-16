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
using CNegocio.Plataforma;
using Modelos.Session;

namespace Sistema_Bancario.plataforma_controles
{
    public partial class NuevoPrestamoUserControl : UserControl
    {
        private CuentasModel gCuenta;
        private string gUsuario;
        private PrestamosModel gPrestamo;
        private string modo;

        private BLPrestamo BLPrestamo = new BLPrestamo();
        private BLCuenta BLCuenta = new BLCuenta();
        private BLTipoMoneda BLTipoMoneda = new BLTipoMoneda();

        public NuevoPrestamoUserControl(ISession session)
        {
            InitializeComponent();
            this.gUsuario = session.UserName;

            this.poblarCboMonedas();

            this.clearForm();
            this.modoInicial();
        }

        private void poblarCboMonedas()
        {
            var objetos = this.BLTipoMoneda.TipoMonedaModelSelectAll();

            if (objetos == null)
            {
                return;
            }

            this.cboMoneda.DataSource = objetos;
            this.cboMoneda.DisplayMember = "Nombre";
            this.cboMoneda.ValueMember = "Id";
        }

        private PrestamosModel gui2prestamo()
        {
            try
            {
                var objcuenta = this.BLCuenta.Getcuenta(this.gCuenta.Nrocuenta);


                DateTime fechaPrestamo = this.dtpFechaPrestamo.Value;
                decimal montoPrestamo = Convert.ToDecimal(this.txtMontoPrestamo.Text);
                int moneda = (int)this.cboMoneda.SelectedValue;
                int plazoMeses = Convert.ToInt32(this.nudPlazoMeses.Value);
                decimal porcentaje_Interes = Convert.ToInt32(this.nudPorcentajeInteres.Value);
                bool seguro = this.chkEstado.Checked;
                string cuenta = objcuenta.Nrocuenta;
                decimal? interes_Moratorio = Convert.ToDecimal(this.txtMontoMora.Text);
                int? DiaPago = Convert.ToInt32(this.nudDiaPago.Value);
                string USUARIO_CREADOR = this.gUsuario;
                DateTime FECHA_CREACION = (DateTime)BLFechaHoraServidor.Obtener();


                return new PrestamosModel()
                {
                    Fechaprestamo = fechaPrestamo,
                    Montoprestamo = montoPrestamo,
                    Moneda = moneda,
                    Plazomeses = plazoMeses,
                    Porcentaje_interes = porcentaje_Interes,
                    Seguro = seguro,
                    Cuenta = cuenta,
                    Interes_moratorio = interes_Moratorio,
                    Usuario_creador = USUARIO_CREADOR,
                    Fecha_creacion = FECHA_CREACION,
                    Diapago = DiaPago,
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void prestamo2gui(PrestamosModel aprestamo)
        {
            this.txtCodigo.Text = aprestamo.Id.ToString();
            this.txtCuenta.Text = aprestamo.Cuenta;
            this.txtMontoPrestamo.Text = aprestamo.Montoprestamo.ToString();
            this.txtMontoMora.Text = aprestamo.Interes_moratorio.ToString();
            this.dtpFechaPrestamo.Value = aprestamo.Fechaprestamo;
            this.cboMoneda.SelectedValue = aprestamo.Moneda;
            this.nudPlazoMeses.Value = aprestamo.Plazomeses;
            this.nudPorcentajeInteres.Value = aprestamo.Porcentaje_interes;
            this.nudDiaPago.Value = (decimal)aprestamo.Diapago;
            this.chkEstado.Checked = aprestamo.Seguro;
        }

        private void cuenta2gui(CuentasModel acuenta)
        {
            this.txtCuenta.Text = acuenta.Nrocuenta.ToUpper();
            this.cboMoneda.SelectedIndex = acuenta.Tipomoneda;
            this.cboMoneda.Enabled = false;
        }

        private void clearForm()
        {
            this.txtCodigo.Text = default(string);
            this.txtCuenta.Text = default(string);
            this.txtMontoPrestamo.Text = default(string);
            this.txtMontoMora.Text = default(string);
            this.dtpFechaPrestamo.Value = DateTime.Now;
            this.cboMoneda.SelectedValue = -1;
            this.nudPlazoMeses.Value = 0m;
            this.nudPorcentajeInteres.Value = 0m;
            this.nudDiaPago.Value = 0m;
            this.chkEstado.Checked = false;

            this.SlblUsuario_creador.Text = "*";
            this.SlblFecha_creacion.Text = "*";
            this.SlblUsuario_modificador.Text = "*";
            this.SlblFecha_modificacion.Text = "*";
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
            this.txtMontoPrestamo.Enabled = true;
            this.txtMontoMora.Enabled = true;
            this.dtpFechaPrestamo.Enabled = true;
            this.cboMoneda.Enabled = true;
            this.nudPlazoMeses.Enabled = true;
            this.nudPorcentajeInteres.Enabled = true;
            this.nudDiaPago.Enabled = true;
            this.chkEstado.Enabled = true;
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
            //this.txtNombres.Enabled = true;
            //this.txtApellidos.Enabled = true;
            //this.txtNumero_documento.Enabled = true;
            //this.txtCorreo.Enabled = false;
            //this.txtTelefono.Enabled = false;
            //this.chkEstado.Enabled = false;

            //this.cboTipo_documento.Enabled = false;
            //this.cboTipoPersona.Enabled = false;
            //this.dtpFecha_nacimiento.Enabled = false;
        }

        private void modoEdicion()
        {
            this.modo = "modoEdicion";

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
            var objeto = this.gui2prestamo();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }
            if (this.BLPrestamo.Insert(objeto))
            {
                this.clearForm();
                this.modoInicial();
                MessageBox.Show("El proceso ha sido correcto");
            }
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            string cuenta = this.txtCuenta.Text;

            var objeto = this.BLCuenta.cuentaSelectbyNroCuentaPrestamo(cuenta);

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
                        CuentasModel dato = formHelp1.getObject<CuentasModel>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gCuenta = this.BLCuenta.Getcuenta(dato.Nrocuenta);

                            if (this.modo == "modoInicial")
                            {
                                if (this.gCuenta == null)
                                    return;

                                List<PrestamosModel> Prestamos = this.BLPrestamo.prestamoSelectbyNroCuenta(this.gCuenta.Nrocuenta);
                                if (Prestamos == null || Prestamos.Count == 0)
                                {
                                    MessageBox.Show("No tiene prestamos asociados a esta cuenta");
                                    return;
                                }
                                    

                                this.buscarPrestamo(Prestamos);
                            }
                            else
                            {
                                this.clearForm();
                                this.cuenta2gui(this.gCuenta);
                            }

                        }
                    }
                }
            }
        }

        private void buscarPrestamo(List<PrestamosModel> objetos)
        {
            string[][] orden = new string[4][];

            orden[0] = new string[] { "ID", "Codigo", "80" };
            orden[1] = new string[] { "FechaPrestamo", "Fecha de Prestamo", "150" };
            orden[2] = new string[] { "Cuenta", "Cuenta", "200" };
            orden[3] = new string[] { "MontoPrestamo", "Codigo", "100" };


            if (objetos != null)
            {
                using (Ayuda.FormHelp2 formHelp1 = new Ayuda.FormHelp2())
                {
                    formHelp1.setList(objetos, orden);
                    formHelp1.ShowDialog();

                    if (formHelp1.EstaAceptado())
                    {
                        var dato = formHelp1.getObject<PrestamosModel>();
                        if (dato != null)
                        {
                            this.clearForm();
                            this.gPrestamo = this.BLPrestamo.Getprestamo(dato.Id);
                            this.prestamo2gui(this.gPrestamo);
                            this.modoNuevo();
                            this.modoEdicion();
                        }
                    }
                }
            }
        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            var objeto = this.gui2prestamo();

            if (objeto == null)
            {
                MessageBox.Show("Problemas al instanciar el nuevo objeto, revise las propiedas");
                return;
            }

            objeto.Id = this.gPrestamo.Id;
            objeto.Usuario_creador = this.gPrestamo.Usuario_creador;
            objeto.Fecha_creacion = this.gPrestamo.Fecha_creacion;
            objeto.Usuario_modificador = this.gUsuario;
            objeto.Fecha_modificacion = BLFechaHoraServidor.Obtener();

            if (this.BLPrestamo.Update(objeto))
            {
                MessageBox.Show("El proceso ha sido correcto");
                this.clearForm();
                this.modoInicial();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (this.gPrestamo == null)
            {
                MessageBox.Show("Problemas al obtener el objeto de base de datos");
                return;
            }
            if (this.BLPrestamo.Delete(this.gPrestamo.Id))
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

            var objeto = this.BLPrestamo.prestamoSelectbyID(codigo);

            if (objeto == null && objeto.Count <= 0) { return; }
            this.buscarPrestamo(objeto);
        }


    }
}
