﻿using CDatos.Manager;
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
            CuentaManager managerCuenta = new CuentaManager();
            CuentasModel cuenta = new CuentasModel()
            {
                Nrocuenta = aprestamo.Cuenta,
                Saldocontable = aprestamo.Montoprestamo,
                Usuario_modificador = aprestamo.Usuario_creador,
                Fecha_modificacion = aprestamo.Fechaprestamo
            };

            return (this.managerPrestamo.Insert(aprestamo) && managerCuenta.DepositarPrestamo(cuenta));
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

        #endregion

    }
}
