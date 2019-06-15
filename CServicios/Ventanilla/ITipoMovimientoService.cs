using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Ventanilla
{
    public interface ITipoMovimientoService
    {
        [OperationContract]
        bool TipoMovimiento_Crear(MovimientosVentanillaModel aEmpresaModel);

        [OperationContract]
        bool TipoMovimiento_Editar(MovimientosVentanillaModel aEmpresaModel);

        [OperationContract]
        bool TipoMovimiento_Eliminar(int aID_EmpresaModel);

        [OperationContract]
        MovimientosVentanillaModel TipoMovimiento_ObtenerUno(int aID_EmpresaModel);

        [OperationContract]
        List<MovimientosVentanillaModel> TipoMovimiento_ObtenerTodos();
    }
}
