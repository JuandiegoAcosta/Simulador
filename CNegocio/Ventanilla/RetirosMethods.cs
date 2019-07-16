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
        public int InsertaRetiro(decimal monto,Int64 tarjeta,int clave,string doi,string usuario)
        {
            return retirosManager.RetiroInsert(monto,tarjeta,clave,doi,usuario);
        }
    }
}
