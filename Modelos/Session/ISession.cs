using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Session
{
   public interface ISession
   {
      #region [ USUARIO ]
      string UserCodigo { get; set; }
      string UserName { get; set; }
      string UserNombreCompleto { get; set; }
      #endregion

      #region [ SUCURSAL ]
      string SucursalCodigo { get; set; }
      string SucursalNombre { get; set; }
      string SucursalUbicacion { get; set; }
      string SucursalCodigoBanco { get; set; }

      #endregion
   }
}
