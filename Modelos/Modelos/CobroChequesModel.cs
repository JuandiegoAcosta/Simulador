using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class CobroChequesModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id_cheque value.
        /// </summary>
        public int Id_cheque
        { get; set; }

        /// <summary>
        /// Gets or sets the Monto value.
        /// </summary>
        public decimal Monto
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado_cheque value.
        /// </summary>
        public bool Estado_cheque
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_movimiento value.
        /// </summary>
        public int Id_movimiento
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
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        public string Usuario_creador
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        public string Usuario_modificador
        { get; set; }


        #endregion
    }

}
