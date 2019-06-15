using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Ventanilla
{
    public interface IRecaudosService
    {
        [OperationContract]
        bool Recaudos_Crear(RecaudosModel aEmpresaModel);

        [OperationContract]
        bool Recaudos_Editar(RecaudosModel aEmpresaModel);

        [OperationContract]
        bool Recaudos_Eliminar(int aID_EmpresaModel);

        [OperationContract]
        RecaudosModel Recaudos_ObtenerUno(int aID_EmpresaModel);

        [OperationContract]
        List<RecaudosModel> Recaudos_ObtenerTodos();
    }
}
