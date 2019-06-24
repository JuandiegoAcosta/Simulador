using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class GirosMethods
    {
        //SelectGirosbyDocClave
        private GiroManager ADGirosPersonaManager;

        public GirosMethods()
        {
            ADGirosPersonaManager = new GiroManager();
        }
        public bool Crear(GiroModel aEmpresaModel)
        {
            return ADGirosPersonaManager.Insert(aEmpresaModel);
        }

        public bool Editar(GiroModel aEmpresaModel)
        {
            return ADGirosPersonaManager.Update(aEmpresaModel);
        }

        public bool Eliminar(int aID_EmpresaModel)
        {
            return ADGirosPersonaManager.Delete(aID_EmpresaModel);
        }

        public EmpresaModel ObtenerUno(int aID_EmpresaModel)
        {
            return ADGirosPersonaManager.GetEmpresaModel(aID_EmpresaModel);
        }

        public List<EmpresaModel> ObtenerTodos()
        {
            return ADGirosPersonaManager.EmpresaModelSelectAll();
        }
        public List<EmpresaModel> BuscarEmpresa(string Nombre)
        {
            return ADGirosPersonaManager.BuscarEmpresa(Nombre);
        }
        public List<RecaudosModel> PagoServicioEmpresa(int id)
        {
            return ADGirosPersonaManager.PagoServicioEmpresa(id);
        }
    }
}
