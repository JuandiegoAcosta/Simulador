using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Bancario.Clases;
using Modelos.Session;
using Modelos.Modelos;

namespace Sistema_Bancario.Ventanilla
{
    public partial class Balancin : UserControl
    {

        public ISession session;
        private int IndiceDataGrid = 0;
        private int SumaTotal = 0;
        public Balancin(ISession sesion)
        {
            this.session = sesion;
            InitializeComponent();
            this.BackColor = Color.White;
            //this.CargarComboMoneda();
            //this.CargarComboRolesSujetos();
            this.CargarComboSujetos();
            this.CargarTipoMovimiento();
        }
        private Balancin()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            //this.CargarComboMoneda();
            //this.CargarComboRolesSujetos();
            this.CargarComboSujetos();
            this.CargarTipoMovimiento();

        }
        private static Balancin _instance;
        public static Balancin instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Balancin();
                }

                return _instance;
            }
        }

        //private void cmbMonedas_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    if (cmbMonedas.SelectedIndex==0)
        //    {
        //        this.CmbDenominaciones.DataSource = null;
        //        this.CmbDenominaciones.DataSource =Denominaciones.Instance.soles;
        //    }else if(cmbMonedas.SelectedIndex==1)
        //    {
        //        this.CmbDenominaciones.DataSource = null;
        //        this.CmbDenominaciones.DataSource = Denominaciones.Instance.dolares;
        //    }
        //}
        //private void CargarComboMoneda()
        //{
        //    using (WsSistemaBancario.TipoMonedaServiceClient moneda=new WsSistemaBancario.TipoMonedaServiceClient())
        //    {
        //        cmbMonedas.DataSource = moneda.Moneda_ObtenerTodos();
        //        cmbMonedas.DisplayMember = "Nombre";
        //    }
        //}
        //private void CargarComboRolesSujetos()
        //{
        //    cmbTiposRoles.DataSource =TiposSujeto.Instance.Sujetos;
        //}
        private void CargarComboSujetos()
        {
            try
            {
                using (WsSistemaBancario.VentanillaServiceClient ventanilla = new WsSistemaBancario.VentanillaServiceClient())
                {
                    this.cmbVentanillas.DataSource = ventanilla.GetVentanillasXSucursal(Convert.ToInt32(this.session.SucursalCodigo));
                    this.cmbVentanillas.DisplayMember = "Descripcion";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error");
               
            }
            
        }
        private void CargarTipoMovimiento()
        {
            this.cmbTipoMov.DataSource =TipoMovimiento.Instance.Movimientos;
        }

        //private void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    this.SumaTotal = 0;
        //    int n = dgvDenominaciones.Rows.Add();
        //    this.dgvDenominaciones.Rows[n].Cells[0].Value = this.CmbDenominaciones.SelectedValue;
        //    this.dgvDenominaciones.Rows[n].Cells[1].Value = this.nudNroBilletes.Value;
        //    this.dgvDenominaciones.Rows[n].Cells[2].Value = this.CalcularImporte((string)this.CmbDenominaciones.SelectedValue, (int)this.nudNroBilletes.Value);

        //    //calcular el total

        //    foreach (DataGridViewRow r in dgvDenominaciones.Rows)
        //    {
        //        SumaTotal = SumaTotal+(int)r.Cells[2].Value;
        //    }
        //    this.txtTotal.Text = this.SumaTotal.ToString();
        //}
        /// <summary>
        /// calcula el monto de importe segun la denominacion de moneda y la cantidad
        /// </summary>
        /// <param name="deno">denominacion del billete</param>
        /// <param name="cant">cantidad de billetes</param>
        /// <returns>importe=deno*cant</returns>
        private int CalcularImporte(string deno,int cant)
        {
            switch (deno)
            {
                case "1 dolar":
                    return 1 * cant;
                case "2 dolares":
                    return 2 * cant;   
                case "5 dolares":
                    return 5 * cant;
                case "10 dolares":
                    return 10 * cant;
                case "20 dolares":
                    return 20 * cant;
                case "50 dolares":
                    return 50 * cant;
                case "100 dolares":
                    return 100 * cant;
                case "10 soles":
                    return 10 * cant;
                case "20 soles":
                    return 20 * cant;
                case "50 soles":
                    return 50 * cant;
                case "100 soles":
                    return 100 * cant;
                case "200 soles":
                    return 200 * cant;
            }
            return cant;
        }

        private void dgvDenominaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IndiceDataGrid = e.RowIndex;
            if (e.RowIndex != -1)
            {
                IndiceDataGrid = e.RowIndex;
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            this.SumaTotal = 0;
            if (this.dgvDenominaciones.Rows.Count-1>=IndiceDataGrid & IndiceDataGrid!=-1)
            {
                this.dgvDenominaciones.Rows.RemoveAt(IndiceDataGrid);
            }
            foreach (DataGridViewRow r in dgvDenominaciones.Rows)
            {
                SumaTotal = SumaTotal + (int)r.Cells[2].Value;
            }
            this.txtTotalSoles.Text = this.SumaTotal.ToString();
        }

        //private void cmbTiposRoles_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    this.cmbPersonaRol.DataSource = null;
        //    if (cmbTiposRoles.SelectedIndex==0)//ventanilla
        //    {
        //        this.CargarComboSujetos();
        //    }
        //    else//bodega
        //    {
        //        this.cmbPersonaRol.DataSource = Clases.Bodega.Instance.bodegueros;
        //    }
        //}

        private void btnRegistrarMov_Click(object sender, EventArgs e)
        {
            //using (WsSistemaBancario. ventanilla = new WsSistemaBancario.VentanillaServiceClient())
            //{

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
