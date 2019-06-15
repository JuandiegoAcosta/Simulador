using CNegocio.Ventanilla;
using Modelos.Modelos;
using ServiciosBancarios.Ventanilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ServiciosBancarios
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class SistemaBancario : IEmpresaService
    {
        private EmpresaMethods BLEmpresaManager;

        public SistemaBancario()
        {
            BLEmpresaManager = new EmpresaMethods();
        }

        public bool Crear(EmpresaModel aEmpresaModel)
        {
            return BLEmpresaManager.Crear(aEmpresaModel);
        }

        public bool Editar(EmpresaModel aEmpresaModel)
        {
            return BLEmpresaManager.Editar(aEmpresaModel);
        }

        public bool Eliminar(int aID_EmpresaModel)
        {
            return BLEmpresaManager.Eliminar(aID_EmpresaModel);
        }

        public List<EmpresaModel> ObtenerTodos()
        {
            return BLEmpresaManager.ObtenerTodos();
        }

        public EmpresaModel ObtenerUno(int aID_EmpresaModel)
        {
            return BLEmpresaManager.ObtenerUno(aID_EmpresaModel);
        }
    }
}
