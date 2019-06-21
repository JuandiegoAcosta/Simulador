using CNegocio.Ventanilla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sistema_Bancario
{
    public partial class Cuotas : Base
    {
        private CuotasMethods GetCuotasMethods;
        public Cuotas()
        {
            InitializeComponent();
            proceder1.BTProceder.Click += BTProceder_Click;

        }

        private void BTProceder_Click(object sender, EventArgs e)
        {
           
        }

        private static Cuotas _instance;

        public static Cuotas getinstance()
        {
            if (_instance == null)
            {
                _instance = new Cuotas();
            }

            return _instance;
        }

        private void BTBuscarCuota_Click(object sender, EventArgs e)
        {
            GetCuotasMethods = new CuotasMethods();
            
            MessageBox.Show(GetCuotasMethods.ObtenerPrestamos(nro_Documento1.TBNroDocumento.Text).ToString());
        }
    }
}
