using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CNegocio.Ventanilla;
using Modelos.Modelos;

namespace Sistema_Bancario.Froms_opciones
{
    public partial class Servicios : Sistema_Bancario.Base
    {
        private PagoServiciosModel gPagomodels;
        private EmpresaModel gEmpresaModel;

        public Servicios()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;
        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
                             
        }

        private static Servicios _instance;
        public static Servicios instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Servicios();
                }

                return _instance;
            }
        }

        private void BTBuscarEmpresa_Click(object sender, EventArgs e)
        {
            EmpresaMethods empresaMethods = new EmpresaMethods();
          //  GEmpresas.Rows.Add(empresaMethods.BuscarEmpresa(empresa1.TBEmpresa.Text)[0].Id_empresa);
            GEmpresas.Rows.Add(empresaMethods.BuscarEmpresa(empresa1.TBEmpresa.Text)[0].Nombre_empresa);

            /*this.gEmpresaModel = new EmpresaModel()
            {
                Nombre_empresa = empresa1.TBEmpresa.Text,
            };*/
        }

        private void BTNroContrato_Click(object sender, EventArgs e)
        {
            EmpresaMethods empresaMethods = new EmpresaMethods();
            //empresaMethods.PagoServicioEmpresa(1);
            GNroContrato.Rows.Add(empresaMethods.PagoServicioEmpresa(1)[0].Monto);

         /*   int nrocontrato = Convert.ToInt32(this.nroContrato1.TBNroContrato.Text);
            this.gPagomodels = new PagoServiciosModel()
            {
                Nro_contrato = nrocontrato
            };*/
        }
    }
}
