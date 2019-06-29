﻿using Modelos.Modelos;
using System.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Backend
{
    [ServiceContract]
    interface IPersonaService
    {
        [OperationContract]
        bool Persona_Crear(PersonaModel aPersona);

        [OperationContract]
        bool Persona_Editar(PersonaModel aPersona);

        [OperationContract]
        bool Persona_Eliminar(int aID_Persona);

        [OperationContract]
        PersonaModel Persona_ObtenerUno(int aID_Persona);

        [OperationContract]
        List<PersonaModel> Persona_ObtenerTodos();

        [OperationContract]
        PersonaModel Persona_ValidarUsuario(string aUsuario, string aContraseña);

        [OperationContract]
        bool Persona_CambiarContraseña(string aUsuario, string aPassword, string aNewPassword);

        [OperationContract]
        SucursalModel Persona_ObtenerSucursal(int idUsuario);
    }
}