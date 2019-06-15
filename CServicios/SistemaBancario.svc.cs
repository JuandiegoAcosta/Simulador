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
     class SistemaBancario : ICobroChequeService, IEmpresaService, IPagoServicioService, IRecaudosService, ITipoMonedaService, ITipoMovimientoService, IVentanillaService
    {
        private EmpresaMethods BLEmpresaManager;

         SistemaBancario()
        {
            BLEmpresaManager = new EmpresaMethods();
        }

        #region [ Ventanilla Front ]

        bool ICobroChequeService.CobroCheque_CrearCobr(CobroChequesModel aEmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool ICobroChequeService.CobroCheque_Editar(CobroChequesModel aEmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool ICobroChequeService.CobroCheque_Eliminar(int aID_EmpresaModel)
        {
            throw new NotImplementedException();
        }

        List<CobroChequesModel> ICobroChequeService.CobroCheque_ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        CobroChequesModel ICobroChequeService.CobroCheque_ObtenerUno(int aID_EmpresaModel)
        {
            throw new NotImplementedException();
        }

         bool IEmpresaService.Empresa_Crear(EmpresaModel aEmpresaModel)
        {
            return BLEmpresaManager.Crear(aEmpresaModel);
        }

         bool IEmpresaService.Empresa_Editar(EmpresaModel aEmpresaModel)
        {
            return BLEmpresaManager.Editar(aEmpresaModel);
        }

         bool IEmpresaService.Empresa_Eliminar(int aID_EmpresaModel)
        {
            return BLEmpresaManager.Eliminar(aID_EmpresaModel);
        }

         List<EmpresaModel> IEmpresaService.Empresa_ObtenerTodos()
        {
            return BLEmpresaManager.ObtenerTodos();
        }

         EmpresaModel IEmpresaService.Empresa_ObtenerUno(int aID_EmpresaModel)
        {
            return BLEmpresaManager.ObtenerUno(aID_EmpresaModel);
        }

        bool IPagoServicioService.PagoServicio_Crear(PagoServiciosModel aEmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool IPagoServicioService.PagoServicio_Editar(PagoServiciosModel aEmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool IPagoServicioService.PagoServicio_Eliminar(int aID_EmpresaModel)
        {
            throw new NotImplementedException();
        }

        List<PagoServiciosModel> IPagoServicioService.PagoServicio_ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        PagoServiciosModel IPagoServicioService.PagoServicio_ObtenerUno(int aID_EmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool IRecaudosService.Recaudos_Crear(RecaudosModel aEmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool IRecaudosService.Recaudos_Editar(RecaudosModel aEmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool IRecaudosService.Recaudos_Eliminar(int aID_EmpresaModel)
        {
            throw new NotImplementedException();
        }

        List<RecaudosModel> IRecaudosService.Recaudos_ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        RecaudosModel IRecaudosService.Recaudos_ObtenerUno(int aID_EmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool ITipoMovimientoService.TipoMovimiento_Crear(MovimientosVentanillaModel aEmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool ITipoMovimientoService.TipoMovimiento_Editar(MovimientosVentanillaModel aEmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool ITipoMovimientoService.TipoMovimiento_Eliminar(int aID_EmpresaModel)
        {
            throw new NotImplementedException();
        }

        List<MovimientosVentanillaModel> ITipoMovimientoService.TipoMovimiento_ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        MovimientosVentanillaModel ITipoMovimientoService.TipoMovimiento_ObtenerUno(int aID_EmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool IVentanillaService.Ventanilla_Crear(VentanillaModel aEmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool IVentanillaService.Ventanilla_Editar(VentanillaModel aEmpresaModel)
        {
            throw new NotImplementedException();
        }

        bool IVentanillaService.Ventanilla_Eliminar(int aID_EmpresaModel)
        {
            throw new NotImplementedException();
        }

        List<VentanillaModel> IVentanillaService.Ventanilla_ObtenerTodos()
        {
            throw new NotImplementedException();
        }

        VentanillaModel IVentanillaService.Ventanilla_ObtenerUno(int aID_EmpresaModel)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region [ Ventanilla Back ]

        #endregion
    }
}
