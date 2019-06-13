using System;
using System.Collections.Generic;
using Modelos.Modelos;
using CDatos.Manager;
namespace CNegocio.Ventanilla
{
    public class VentanillaMethods
    {
        private ManagerMovimientosVentanillaModel ManagerMovimientosVentanilla;

        public Ventanilla()
        {
            ManagerMovimientosVentanilla = new ManagerMovimientosVentanillaModel();
        }
        public bool CrearOperacion()
        {
            return false;
        }

        public bool PagarServicio()
        {
            return false;
        }

    }

}