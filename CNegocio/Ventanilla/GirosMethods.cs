using CDatos.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class GirosMethods
    {
        //SelectGirosbyDocClave
        private GirosPersonaManager cuotasPrestamosManager;

        public GirosMethods()
        {
            cuotasPrestamosManager = new GirosPersonaManager();
        }

        public List<object> SelectGirosbyDocClave(string avalue,Int16 clave)
        {
            return cuotasPrestamosManager.SelectGirosbyDocClave(avalue,clave);
        }
    }
}
