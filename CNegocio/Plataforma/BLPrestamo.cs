using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Plataforma
{
    public class BLPrestamo
    {
        PrestamoManager managerPrestamo = new PrestamoManager();

        #region Methods
        /// <summary>
        /// Saves a record to the prestamo table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(PrestamosModel aprestamo)
        {
            try
            {

                CuentaManager managerCuenta = new CuentaManager();
                CronogramaPagoManager managerCronograma = new CronogramaPagoManager();
                DateTime? actual = BLFechaHoraServidor.Obtener();
                CuentasModel cuenta = new CuentasModel()
                {
                    Nrocuenta = aprestamo.Cuenta,
                    Saldocontable = aprestamo.Montoprestamo,
                    Usuario_modificador = aprestamo.Usuario_creador,
                    Fecha_modificacion = aprestamo.Fechaprestamo
                };

                managerPrestamo.Insert(aprestamo);
                managerCuenta.DepositarPrestamo(cuenta);


                decimal monto_unitario = (aprestamo.Montoprestamo / aprestamo.Plazomeses) + (aprestamo.Montoprestamo * aprestamo.Porcentaje_interes / 100);

                int dia_pago = (int)aprestamo.Diapago;
                int mes_pago = actual.Value.Month;
                int año_pago = actual.Value.Year;

                for (int i = 0; i < aprestamo.Plazomeses; i++)
                {
                    if (mes_pago == 12)
                    {
                        mes_pago = 1;
                        año_pago++;
                    }
                    else mes_pago++;

                    CronogramaPagosModel cronograma = new CronogramaPagosModel()
                    {
                        Prestamo = aprestamo.Id,
                        //Diapago = Convert.ToDateTime(dia_pago.ToString() + "/" + mes_pago.ToString() + "/" + año_pago.ToString() + String.Format("{0:HH:mm:ss}", "23:59:00")),
                        Diapago = new DateTime(año_pago, mes_pago, dia_pago, 23, 59, 59),
                        Monto = monto_unitario,
                        Estado = 0,
                        Usuario_creador = aprestamo.Usuario_creador,
                        Fecha_creacion = aprestamo.Fecha_creacion
                    };
                    managerCronograma.Insert(cronograma, aprestamo.Cuenta);
                }

                return true;
            }
            catch (Exception)
            {
                //throw;
                return false;
            }
        }


        /// <summary>
        /// Updates a record to the prestamo table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(PrestamosModel aprestamo)
        {
            return this.managerPrestamo.Update(aprestamo);
        }


        /// <summary>
        /// Deletes record to the prestamo table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aID)
        {
            return this.managerPrestamo.Delete(aID);
        }


        /// <summary>
        /// Selects the Single object of prestamo table.
        /// </summary>
        public PrestamosModel Getprestamo(int aID)
        {
            return this.managerPrestamo.Getprestamo(aID);
        }


        /// <summary>
        /// Selects all the objects of prestamo table.
        /// </summary>
        public List<PrestamosModel> prestamoSelectAll()
        {
            return this.managerPrestamo.prestamoSelectAll();
        }

        public List<PrestamosModel> prestamoSelectbyID(string aId)
        {
            return this.managerPrestamo.prestamoSelectbyID(aId);
        }


        public List<PrestamosModel> prestamoSelectbyNroCuenta(string aNumero_cuenta)
        {
            return this.managerPrestamo.prestamoSelectbyNroCuenta(aNumero_cuenta);
        }

        public List<CronogramaPagosModel> CronogramaPagosModelSelectbyIdPrestamo(int id_prestamo)
        {
            return this.managerPrestamo.CronogramaPagosModelSelectbyIdPrestamo(id_prestamo);
        }

        #endregion

    }
}
