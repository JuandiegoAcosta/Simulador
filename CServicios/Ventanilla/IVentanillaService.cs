using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Ventanilla
{
    public interface IVentanillaService
    {
        [OperationContract]
        bool Ventanilla_Crear(VentanillaModel aEmpresaModel);

        [OperationContract]
        bool Ventanilla_Editar(VentanillaModel aEmpresaModel);

        [OperationContract]
        bool Ventanilla_Eliminar(int aID_EmpresaModel);

        [OperationContract]
        VentanillaModel Ventanilla_ObtenerUno(int aID_EmpresaModel);

        [OperationContract]
        List<VentanillaModel> Ventanilla_ObtenerTodos();
    }
}
