
using CDatos.Manager;

namespace CNegocio.Ventanilla
{
    public class VentanillaMethods
    {
        private ManagerMovimientosVentanillaModel ManagerMovimientosVentanilla;

        public VentanillaMethods()
        {
            ManagerMovimientosVentanilla = new ManagerMovimientosVentanillaModel();
        }

        #region Front
        public bool CrearOperacion()
        {
            return false;
        }

        public bool PagarServicio()
        {
            return false;
        }

        #endregion
    }

}