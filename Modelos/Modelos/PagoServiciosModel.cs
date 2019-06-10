using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class PagoServiciosModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Nro_contrato value.
        /// </summary>
        public int Nro_contrato
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_movimiento value.
        /// </summary>
        public int Id_movimiento
        { get; set; }

        /// <summary>
        /// Gets or sets the Fechapago value.
        /// </summary>
        public DateTime Fechapago
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_creacion value.
        /// </summary>
        public DateTime Fecha_creacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        public DateTime? Fecha_modificacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        public string Usuario_modificador
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        public string Usuario_creador
        { get; set; }


        #endregion
    }

}
