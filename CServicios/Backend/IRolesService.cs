﻿using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ServiciosBancarios.Backend
{
    [ServiceContract]
    interface IRolesService
    {
        [OperationContract]
        bool Roles_Crear(RolesModel aRoles);

        [OperationContract]
        bool Roles_Editar(RolesModel aRoles);

        [OperationContract]
        bool Roles_Eliminar(int aID_Roles);

        [OperationContract]
        RolesModel Roles_ObtenerUno(int aID_Roles);

        [OperationContract]
        List<RolesModel> Roles_ObtenerTodos();

        [OperationContract]
        DataTable Roles_RolesPorPersona(int aID_Usuario);
    }
}
