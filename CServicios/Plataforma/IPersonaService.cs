﻿using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Plataforma
{
    [ServiceContract]
    interface ICuentaService
    {
        [OperationContract]
        bool Cuenta_Crear(CuentasModel aCuenta);

        [OperationContract]
        bool Cuenta_Editar(CuentasModel aCuenta);

        [OperationContract]
        CuentasModel Cuenta_ObtenerUno(string aNro_Cuenta);

        [OperationContract]
        List<CuentasModel> Cuenta_ObtenerTodos(int aID_Persona);

    }
}