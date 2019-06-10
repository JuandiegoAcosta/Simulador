using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class RecaudosModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Nro_contrato value.
        /// </summary>
        public int Nro_contrato
        { get; set; }

        /// <summary>
        /// Gets or sets the Monto value.
        /// </summary>
        public decimal Monto
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_vencimiento value.
        /// </summary>
        public DateTime Fecha_vencimiento
        { get; set; }

        /// <summary>
        /// Gets or sets the Estado_recaudo value.
        /// </summary>
        public bool Estado_recaudo
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_empresa value.
        /// </summary>
        public int Id_empresa
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
