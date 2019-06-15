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
     public class SistemaBancario : ICobroChequeService, IEmpresaService, IPagoServicioService, IRecaudosService, ITipoMonedaService, ITipoMovimientoService, IVentanillaService
    {
        #region [ Varibles Globales ]
        #region [ Ventanilla Front ]
        private CobroChequeMethods BLCobroCheque;
        private EmpresaMethods BLEmpresa;
        private PagoServicioMethods BLPagoServicio;
        private RecaudoMethods BLRecaudos;
        private TipoMonedaMethods BLTipoMoneda;
        private TipoMovimientoMethods BLTipoMovimiento;
        private VentanillaMethods BLVentanila;
        #endregion

        #region [ Ventanilla Back ]
        //Pon tus variables aqui :)
        #endregion

        #region [ Plataforma ]
        //pon tus variables aqui :)
        #endregion
        #endregion

        public SistemaBancario()
        {
            #region [ Ventanilla Front ]
            BLEmpresa = new EmpresaMethods();
            BLEmpresa = new EmpresaMethods();
            BLPagoServicio = new PagoServicioMethods();
            BLRecaudos = new RecaudoMethods();
            BLTipoMoneda = new TipoMonedaMethods();
            BLTipoMovimiento = new TipoMovimientoMethods();
            BLVentanila = new VentanillaMethods();
            #endregion

            #region [ Ventanilla Back ]
            //Pon tus variables aqui :)
            #endregion

            #region [ Plataforma ]
            //pon tus variables aqui :)
            #endregion
        }

        #region [ Ventanilla Front ]

        #region [ Cobro cheque ]
        bool ICobroChequeService.CobroCheque_Crear(CobroChequesModel aCobroCheque)
        {
            return BLCobroCheque.Crear(aCobroCheque);
        }

        bool ICobroChequeService.CobroCheque_Editar(CobroChequesModel aCobroCheque)
        {
            return BLCobroCheque.Editar(aCobroCheque);
        }

        bool ICobroChequeService.CobroCheque_Eliminar(int aID_Cheque, int aID_Movimiento)
        {
            return BLCobroCheque.Eliminar(aID_Cheque, aID_Movimiento);
        }

        List<CobroChequesModel> ICobroChequeService.CobroCheque_ObtenerTodos()
        {
            return BLCobroCheque.ObtenerTodos();
        }

        CobroChequesModel ICobroChequeService.CobroCheque_ObtenerUno(int aID_Cheque, int aID_Movimiento)
        {
            return BLCobroCheque.ObtenerUno(aID_Cheque, aID_Movimiento);
        }
        #endregion

        #region [ Empresa ]
        bool IEmpresaService.Empresa_Crear(EmpresaModel aEmpresaModel)
        {
            return BLEmpresa.Crear(aEmpresaModel);
        }

        bool IEmpresaService.Empresa_Editar(EmpresaModel aEmpresaModel)
        {
            return BLEmpresa.Editar(aEmpresaModel);
        }

        bool IEmpresaService.Empresa_Eliminar(int aID_EmpresaModel)
        {
            return BLEmpresa.Eliminar(aID_EmpresaModel);
        }

        List<EmpresaModel> IEmpresaService.Empresa_ObtenerTodos()
        {
            return BLEmpresa.ObtenerTodos();
        }

        EmpresaModel IEmpresaService.Empresa_ObtenerUno(int aID_EmpresaModel)
        {
            return BLEmpresa.ObtenerUno(aID_EmpresaModel);
        }
        #endregion

        #region [ Pago Servicio ]
        bool IPagoServicioService.PagoServicio_Crear(PagoServiciosModel aPagoServicios)
        {
            return BLPagoServicio.Crear(aPagoServicios);
        }

        bool IPagoServicioService.PagoServicio_Editar(PagoServiciosModel aPagoServicios)
        {
            return BLPagoServicio.Editar(aPagoServicios);
        }

        bool IPagoServicioService.PagoServicio_Eliminar(int aNro_Contrato, int aID_Movimiento)
        {
            return BLPagoServicio.Eliminar(aNro_Contrato, aID_Movimiento);
        }

        List<PagoServiciosModel> IPagoServicioService.PagoServicio_ObtenerTodos()
        {
            return BLPagoServicio.ObtenerTodos();
        }

        PagoServiciosModel IPagoServicioService.PagoServicio_ObtenerUno(int aNro_Contrato, int aID_Movimiento)
        {
            return BLPagoServicio.ObtenerUno(aNro_Contrato, aID_Movimiento);
        }

        #endregion

        #region [ Recaudos ]
        bool IRecaudosService.Recaudos_Crear(RecaudosModel aRecaudos)
        {
            return BLRecaudos.Crear(aRecaudos);
        }

        bool IRecaudosService.Recaudos_Editar(RecaudosModel aRecaudos)
        {
            return BLRecaudos.Editar(aRecaudos);
        }

        bool IRecaudosService.Recaudos_Eliminar(int aNro_Contrato)
        {
            return BLRecaudos.Eliminar(aNro_Contrato);
        }

        List<RecaudosModel> IRecaudosService.Recaudos_ObtenerTodos()
        {
            return BLRecaudos.ObtenerTodos();
        }

        RecaudosModel IRecaudosService.Recaudos_ObtenerUno(int aNro_Contrato)
        {
            return BLRecaudos.ObtenerUno(aNro_Contrato);
        }

        #endregion

        #region [ Tipo Moneda ]

        #endregion

        #region [ Tipo Movimiento ]

        bool ITipoMovimientoService.TipoMovimiento_Crear(MovimientosVentanillaModel aMovimientoVentanilla)
        {
            return BLTipoMovimiento.Crear(aMovimientoVentanilla);
        }

        bool ITipoMovimientoService.TipoMovimiento_Editar(MovimientosVentanillaModel aMovimientoVentanilla)
        {
            return BLTipoMovimiento.Editar(aMovimientoVentanilla);
        }

        bool ITipoMovimientoService.TipoMovimiento_Eliminar(int aID_Movimiento)
        {
            return BLTipoMovimiento.Eliminar(aID_Movimiento);
        }

        List<MovimientosVentanillaModel> ITipoMovimientoService.TipoMovimiento_ObtenerTodos()
        {
            return BLTipoMovimiento.ObtenerTodos();
        }

        MovimientosVentanillaModel ITipoMovimientoService.TipoMovimiento_ObtenerUno(int aID_Movimiento)
        {
            return BLTipoMovimiento.ObtenerUno(aID_Movimiento);
        }
        #endregion

        #region [ Ventanilla ]

        bool IVentanillaService.Ventanilla_Crear(VentanillaModel aVentanilla)
        {
            return BLVentanila.Crear(aVentanilla);
        }

        bool IVentanillaService.Ventanilla_Editar(VentanillaModel aVentanilla)
        {
            return BLVentanila.Editar(aVentanilla);
        }

        bool IVentanillaService.Ventanilla_Eliminar(int aID_VentanillaModel)
        {
            return BLVentanila.Eliminar(aID_VentanillaModel);
        }

        List<VentanillaModel> IVentanillaService.Ventanilla_ObtenerTodos()
        {
            return BLVentanila.ObtenerTodos();
        }

        VentanillaModel IVentanillaService.Ventanilla_ObtenerUno(int aID_VentanillaModel)
        {
            return BLVentanila.ObtenerUno(aID_VentanillaModel);
        }
        #endregion

        #endregion

        #region [ Ventanilla Back ]
        //Pon tus mentodos aqui :)
        #endregion

        #region [ Plataforma ]
        //pon tus metodos aqui :)
        #endregion
    }
}
