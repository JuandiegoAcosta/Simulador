using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class RolUsuarioModel
    {
        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_personas value.
        /// </summary>
        public int? Id_persona
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_roles value.
        /// </summary>
        public int? Id_rol
        { get; set; }

        /// <summary>
        /// Gets or sets the Activo value.
        /// </summary>
        public bool Activo
        { get; set; }

        #endregion
    }

}
