using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Ventanilla
{
    public interface IPagoServicioService
    {
        [OperationContract]
        bool PagoServicio_Crear(PagoServiciosModel aEmpresaModel);

        [OperationContract]
        bool PagoServicio_Editar(PagoServiciosModel aEmpresaModel);

        [OperationContract]
        bool PagoServicio_Eliminar(int aID_EmpresaModel);

        [OperationContract]
        PagoServiciosModel PagoServicio_ObtenerUno(int aID_EmpresaModel);

        [OperationContract]
        List<PagoServiciosModel> PagoServicio_ObtenerTodos();
    }
}
