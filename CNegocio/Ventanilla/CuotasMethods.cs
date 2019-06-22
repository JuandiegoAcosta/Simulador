using CDatos.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class CuotasMethods
    {
        private CuotasPrestamosManager cuotasPrestamosManager;

        public CuotasMethods()
        {
            cuotasPrestamosManager = new CuotasPrestamosManager();
        }

        public List<object> ObtenerPrestamos(string avalue)
        {
            return cuotasPrestamosManager.CuotasPrestamosSelect(avalue);
        }
        //CuotasSelect
        public List<object> CuotasSelect(int avalue)
        {
            return cuotasPrestamosManager.CuotasSelect(avalue);
        }
    }
}
