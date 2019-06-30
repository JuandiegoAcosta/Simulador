using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Session
{
   public class Session : ISession
   {
      public string UserCodigo { get; set; }
      public string UserName { get; set; }
      public string UserNombreCompleto { get; set; }

      public string SucursalCodigo { get; set; }
      public string SucursalNombre { get; set; }
      public string SucursalUbicacion { get; set; }
      public string SucursalCodigoBanco { get; set; }
   }
}
