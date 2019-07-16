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
         if (GNroContrato.Rows.Count > 0)
         {
            PagoServicioMethods pagoServicioMethods = new PagoServicioMethods();
            int i = GNroContrato.CurrentCell.RowIndex;


            pagoServicioMethods.InsertPagoServicio(Convert.ToInt32(nroContrato1.TBNroContrato.Text));

         }
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
          
            GEmpresas.DataSource = empresaMethods.BuscarEmpresa(empresa1.TBEmpresa.Text);

        }

        private void BTNroContrato_Click(object sender, EventArgs e)
        {
         if (GEmpresas.Rows.Count > 0)
         {
            if (string.IsNullOrEmpty(nroContrato1.TBNroContrato.Text)) { return; }


            EmpresaMethods empresaMethods = new EmpresaMethods();

            int i = GEmpresas.CurrentCell.RowIndex;

            var source = new BindingSource(empresaMethods.PagoServicioEmpresa(Convert.ToInt32(GEmpresas[0, i].Value), Convert.ToInt32(nroContrato1.TBNroContrato.Text)), null);
            GNroContrato.DataSource = source;
         }
        }
    }
}
