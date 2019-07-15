﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class DetalleCajaChicaModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public int Id
        { get; set; }

        /// <summary>
        /// Gets or sets the Id_CajaChica value.
        /// </summary>
        public int Id_CajaChica
        { get; set; }

        /// <summary>
        /// Gets or sets the Denominacion value.
        /// </summary>
        public decimal Denominacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Cantidad value.
        /// </summary>
        public int Cantidad
        { get; set; }

        /// <summary>
        /// Gets or sets the Moneda value.
        /// </summary>
        public string Moneda
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_creador value.
        /// </summary>
        public string Usuario_creador
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_creacion value.
        /// </summary>
        public DateTime Fecha_creacion
        { get; set; }

        /// <summary>
        /// Gets or sets the Usuario_modificador value.
        /// </summary>
        public string Usuario_modificador
        { get; set; }

        /// <summary>
        /// Gets or sets the Fecha_modificacion value.
        /// </summary>
        public DateTime? Fecha_modificacion
        { get; set; }


        #endregion


    }
}
