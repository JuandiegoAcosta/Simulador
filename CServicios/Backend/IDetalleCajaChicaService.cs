﻿using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
namespace ServiciosBancarios.Backend
{
    interface IDetalleCajaChicaService
    {

        [OperationContract]
        bool DetalleCajaChica_Crear(DetalleCajaChicaModel aDetalleCajaChica);

        [OperationContract]
        bool DetalleCajaChica_Editar(DetalleCajaChicaModel aDetalleCajaChica);

        [OperationContract]
        bool DetalleCajaChica_Eliminar(int aID_DetalleCajaChica);

        [OperationContract]
        DetalleCajaChicaModel DetalleCajaChica_ObtenerUno(int aID_DetalleCajaChica);

        [OperationContract]
        List<DetalleCajaChicaModel> DetalleCajaChica_ObtenerTodos();

    }
}
