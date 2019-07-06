using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
   public class CuentasTarjetasModel
    {
        public decimal Monto { get; set; }
        public int clave { get; set; }
        public int NroCuenta { get; set; }
        public int NroCuentaDestino { get; set; }
        public int doi { get; set; }

        public CuentasTarjetasModel() { }
    }
}
