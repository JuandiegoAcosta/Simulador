
using CDatos.Manager;
using Modelos.Modelos;
using System.Collections.Generic;

namespace CNegocio.Ventanilla
{
    public class VentanillaMethods
    {
        private VentanillaManager ADVentanillaManager;

        public VentanillaMethods()
        {
            ADVentanillaManager = new VentanillaManager();
        }
        public bool Crear(VentanillaModel aVentanilla)
        {
            return ADVentanillaManager.Insert(aVentanilla);
        }

        public bool Editar(VentanillaModel aVentanilla)
        {
            return ADVentanillaManager.Update(aVentanilla);
        }

        public bool Eliminar(int aID_VentanillaModel)
        {
            return ADVentanillaManager.Delete(aID_VentanillaModel);
        }

        public VentanillaModel ObtenerUno(int aID_VentanillaModel)
        {
            return ADVentanillaManager.GetVentanillaModel(aID_VentanillaModel);
        }

        public List<VentanillaModel> ObtenerTodos()
        {
            return ADVentanillaManager.VentanillaModelSelectAll();
        }
        public List<VentanillaModel> ObtenerVentanillasXSucursal(int sucursal)
        {
            return ADVentanillaManager.GetVentanillasXSucursal(sucursal);
        }
    }

}