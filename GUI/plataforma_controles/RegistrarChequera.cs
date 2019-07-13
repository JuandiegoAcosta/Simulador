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

namespace Sistema_Bancario.plataforma_controles
{
    public partial class RegistrarChequera : UserControl
    {

        private BLCuenta BLCuenta = new BLCuenta();
        private string modo;


        private ChequerasModel gChequera;

        public RegistrarChequera()
        {
            InitializeComponent();
            this.poblarCboTipoCuenta();
            this.poblarCboEstado();
        }

        private void poblarCboTipoCuenta()
        {
            SortedDictionary<int, string> userCache = new SortedDictionary<int, string>
                {
                  {50, "050 CHEQUES"},
                  {100, "100 CHUEQUES"},
                  {150, "150 CHEQUES"}
                };

            this.cboCantidadCheques.DataSource = new BindingSource(userCache, null);
            this.cboCantidadCheques.ValueMember = "Key";
            this.cboCantidadCheques.DisplayMember = "Value";
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

                            if (this.modo == "modoInicial")
                            {
                                if (this.gChequera == null)
                                    return;

                                //var Prestamos = this.BLPrestamo.prestamoSelectbyNroCuenta(this.gCuenta.Nrocuenta);
                                //if (Prestamos == null || Prestamos.Count == 0)
                                //    return;

                                //this.buscarPrestamo(Prestamos);
                            }
                            else
                            {
                                //this.clearForm();
                                //this.cuenta2gui(this.gCuenta);
                            }

                        }
                    }
                }
            }
        }
    }
}
