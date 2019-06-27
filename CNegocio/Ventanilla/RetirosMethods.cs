using CDatos.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
   public class RetirosMethods
    {
        private RetirosManager retirosManager;

        public RetirosMethods()
        {
            retirosManager = new RetirosManager();
        }
        //RetiroInsert
        public int InsertaRetiro(decimal monto,int tarjeta,int clave,string doi)
        {
            return retirosManager.RetiroInsert(monto,tarjeta,clave,doi);
        }
    }
}
