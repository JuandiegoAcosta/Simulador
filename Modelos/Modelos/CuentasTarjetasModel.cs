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
        public long NroCuenta { get; set; }
        public long NroCuentaDestino { get; set; }
        public int doi { get; set; }
        public string Usuario { get; set; }

        public CuentasTarjetasModel() { }
    }
}
