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

namespace Sistema_Bancario.Plataforma
{
    public partial class UCchequeras : UserControl
    {
        private string gUsuario;
        private BLChequeras BLChequeras = new BLChequeras();


        public UCchequeras()
        {
            InitializeComponent();
        }
        public UCchequeras(string usuario)
        {
            InitializeComponent();
            this.gUsuario = usuario;
        }
        private static UCchequeras _instance;
        public static UCchequeras instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UCchequeras();
                }

                return _instance;
            }
        }
        private void MantenimientoChequeras_Load(object sender, EventArgs e)
        {

        }
        private void Nuevo()
        {
            txtNumero.Text = "";
            dtpFechaEmision.Value = System.DateTime.Now;
            dtpFechaRegistro.Value = System.DateTime.Now;
        }

        private void proceder1_Load(object sender, EventArgs e)
        {

        }

        private void Guardar()
        {
            //DateTime fechaemision = this.dtpFechaEmision.Value;
            DateTime fecharegistro = this.dtpFechaRegistro.Value;
            string estado = this.cmbEstado.Text;
            int cantidad = Convert.ToInt32(this.cmbCantidad.Text);
            //quitar numero
            int numero = Convert.ToInt32(this.txtNumero.Text);

            ChequerasModel chequerasModel = new ChequerasModel()
            {
                Fecharegistro = fecharegistro,
                Estado = estado,
                Cantidad_cheques = cantidad,
                Numero = numero,
                Usuario_creador = gUsuario,
            };

            if (!this.BLChequeras.Ingresar(chequerasModel))
            {
                MessageBox.Show("Los datos no pudieron ser ingresados.");
            }
            else
            {
                MessageBox.Show("La chequera ha sido solicitada.");
                Nuevo();
            }
        }
    }
}
