﻿using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Ventanilla
{
   public class CuentasMethods
    {
        public CuentaPersonaMonedaModel ValidarCuenta(Int64 nrocuenta)
        {
            CuentaManager cuentaPersonaMonedaModel = new CuentaManager();
           return cuentaPersonaMonedaModel.ValidarCuenta(nrocuenta);
        }
    }
}
