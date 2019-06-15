using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Ventanilla
{
    public interface ICobroChequeService
    {
        [OperationContract]
        bool CobroCheque_CrearCobr(CobroChequesModel aEmpresaModel);

        [OperationContract]
        bool CobroCheque_Editar(CobroChequesModel aEmpresaModel);

        [OperationContract]
        bool CobroCheque_Eliminar(int aID_EmpresaModel);

        [OperationContract]
        CobroChequesModel CobroCheque_ObtenerUno(int aID_EmpresaModel);

        [OperationContract]
        List<CobroChequesModel> CobroCheque_ObtenerTodos();
    }
}
