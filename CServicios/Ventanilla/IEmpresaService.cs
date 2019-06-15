using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace ServiciosBancarios.Ventanilla
{
    public interface IEmpresaService 
    {
        [OperationContract]
        bool Crear(EmpresaModel aEmpresaModel);

        [OperationContract]
        bool Editar(EmpresaModel aEmpresaModel);

        [OperationContract]
        bool Eliminar(int aID_EmpresaModel);

        [OperationContract]
        EmpresaModel ObtenerUno(int aID_EmpresaModel);

        [OperationContract]
        List<EmpresaModel> ObtenerTodos();
    }
}