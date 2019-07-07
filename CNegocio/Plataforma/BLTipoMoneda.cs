using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Manager;
using Modelos.Modelos;

namespace CNegocio.Plataforma
{
    public class BLTipoMoneda
    {
        private TipoMonedaManager ADTipoMonedaManager = new TipoMonedaManager();

        public bool Insert(TipoMonedaModel aTipoMoneda)
        {
            return ADTipoMonedaManager.Insert(aTipoMoneda);
        }

        public bool Update(TipoMonedaModel aTipoMoneda)
        {
            return ADTipoMonedaManager.Update(aTipoMoneda);
        }

        public bool Delete(int aID_Moneda)
        {
            return ADTipoMonedaManager.Delete(aID_Moneda);
        }

        public TipoMonedaModel GetTipoMonedaModel(int aID_Moneda)
        {
            return ADTipoMonedaManager.GetTipoMonedaModel(aID_Moneda);
        }

        public List<TipoMonedaModel> TipoMonedaModelSelectAll()
        {
            return ADTipoMonedaManager.TipoMonedaModelSelectAll();
        }

    }
}
