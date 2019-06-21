using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class HorariosAtencionMethods
    {
        private HorariosAtencionManager ADHorariosAtencionManager;

        public HorariosAtencionMethods()
        {
            ADHorariosAtencionManager = new HorariosAtencionManager();
        }
        public bool Crear(HorariosAtencionModel aHorariosAtencion)
        {
            return ADHorariosAtencionManager.Insert(aHorariosAtencion);
        }

        public bool Editar(HorariosAtencionModel aHorariosAtencion)
        {
            return ADHorariosAtencionManager.Update(aHorariosAtencion);
        }

        public bool Eliminar(int aID_HorariosAtencion)
        {
            return ADHorariosAtencionManager.Delete(aID_HorariosAtencion);
        }

        public HorariosAtencionModel ObtenerUno(int aID_HorariosAtencion)
        {
            return ADHorariosAtencionManager.GetHorarios_AtencionModel(aID_HorariosAtencion);
        }

        public List<HorariosAtencionModel> ObtenerTodos()
        {
            return ADHorariosAtencionManager.Horarios_AtencionModelSelectAll();
        }
    }
}
