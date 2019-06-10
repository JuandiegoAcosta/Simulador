using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Modelos
{
    public class EmpresaModel
    {

        #region Properties

        /// <summary>
        /// Gets or sets the Id_empresa value.
        /// </summary>
        public int Id_empresa
        { get; set; }

        /// <summary>
        /// Gets or sets the Nombre_empresa value.
        /// </summary>
        public string Nombre_empresa
        { get; set; }

        /// <summary>
        /// Gets or sets the Descripcion value.
        /// </summary>
        public string Descripcion
        { get; set; }

        /// <summary>
        /// Gets or sets the Nro_cuenta value.
        /// </summary>
        public string Nro_cuenta
        { get; set; }

        /// <summary>
        /// Gets or sets the Comisiones value.
        /// </summary>
        public decimal Comisiones
        { get; set; }

        /// <summary>
        /// Gets or sets the Empresa_asume_comision value.
        /// </summary>
        public bool Empresa_asume_comision
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
