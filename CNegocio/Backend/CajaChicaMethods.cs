using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class CajaChicaMethods
    {
        private CajaChicaManager ADCajaChicaManager;

        public CajaChicaMethods()
        {
            ADCajaChicaManager = new CajaChicaManager();
        }

        public int Crear(CajaChicaModel aCajaChica,int id_user)
        {
            return ADCajaChicaManager.Insert(aCajaChica, id_user);
        }

        public bool Editar(CajaChicaModel aCajaChica)
        {
            return ADCajaChicaManager.Update(aCajaChica);
        }

        public bool Eliminar(int aID_CajaChica)
        {
            return ADCajaChicaManager.Delete(aID_CajaChica);
        }

        public CajaChicaModel ObtenerUno(int aID_CajaChica)
        {
            return ADCajaChicaManager.GetCajaChicaModel(aID_CajaChica);
        }

        public List<CajaChicaModel> ObtenerTodos()
        {
            return ADCajaChicaManager.Caja_ChicaModelSelectAll();
        }


    }
}
