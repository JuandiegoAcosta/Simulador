using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class DetalleCajaChicaMethods
    {


        private DetalleCajaChicaManager ADDetalleCajaChicaManager;

        public DetalleCajaChicaMethods()
        {
            ADDetalleCajaChicaManager = new DetalleCajaChicaManager();
        }

        public bool Crear(DetalleCajaChicaModel aCajaChica)
        {
            return ADDetalleCajaChicaManager.Insert(aCajaChica);
        }

        public bool Editar(DetalleCajaChicaModel aCajaChica)
        {
            return ADDetalleCajaChicaManager.Update(aCajaChica);
        }

        public bool Eliminar(int aID_CajaChica)
        {
            return ADDetalleCajaChicaManager.Delete(aID_CajaChica);
        }

        public DetalleCajaChicaModel ObtenerUno(int aID_CajaChica)
        {
            return ADDetalleCajaChicaManager.GetDetalleCajaChicaModel(aID_CajaChica);
        }

        public List<DetalleCajaChicaModel> ObtenerTodos()
        {
            return ADDetalleCajaChicaManager.Caja_ChicaModelSelectAll();
        }


    }
}
