using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
    public class EmpresaMethods
    {
        public bool Crear(EmpresaModel aempresa)
        {
            return false;
        }

        public bool Editar(EmpresaModel aempresa)
        {
            return false;
        }

        public bool Eliminar(int identidad)
        {
            return false;
        }

        public EmpresaModel ObtenerUno(int identidad)
        {
            return new EmpresaModel();
        }

        public ObservableCollection<EmpresaModel> ObtenerTodos()
        {
            return new ObservableCollection<EmpresaModel>();
        }
    }
}
