﻿using CDatos.Manager;
using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNegocio.Backend
{
    public class PersonaMethods
    {
        private PersonaManager ADPersonaManager = new PersonaManager();

        /// <summary>
        /// Saves a record to the persona table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>	
        public bool Crear(PersonaModel aPersona)
        {
            return ADPersonaManager.Insert(aPersona);
        }

        /// <summary>
        /// Updates a record to the persona table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Editar(PersonaModel aPersona)
        {
            return ADPersonaManager.Update(aPersona);
        }

        /// <summary>
        /// Deletes record to the persona table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Eliminar(int aID_Persona)
        {
            return ADPersonaManager.Delete(aID_Persona);
        }

        /// <summary>
        /// Selects the Single object of persona table.
        /// </summary>
        public PersonaModel ObtenerUno(int aID_Persona)
        {
            return ADPersonaManager.GetPersonaModel(aID_Persona);
        }

        /// <summary>
        /// Selects all the objects of persona table.
        /// </summary>
        public List<PersonaModel> ObtenerTodos()
        {
            return ADPersonaManager.PersonaModelSelectAll();
        }

        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyID(string aValue)
        {
            return ADPersonaManager.personaSelectbyID(aValue);
        }


        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyNombres(string aValue)
        {
            return ADPersonaManager.personaSelectbyNombres(aValue);
        }


        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyApellidos(string aValue)
        {
            return ADPersonaManager.personaSelectbyApellidos(aValue);
        }


        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyNroDocumento(string aValue)
        {
            return ADPersonaManager.personaSelectbyNroDocumento(aValue);
        }

        public PersonaModel ValidarUsuario(string aUsuario, string aContraseña)
        {
            return ADPersonaManager.ValidarUsuario(aUsuario, aContraseña);
        }

        public bool CambiarContraseña(string aUsuario, string aContraseña, string aNuevaContraseña)
        {

            return ADPersonaManager.CambiarContraseña(aUsuario, aContraseña, aNuevaContraseña);
        }

        public SucursalModel ObtenerSucursal(int idUsuario)
        {
            return ADPersonaManager.ObtenerSucursal(idUsuario);
        }

        public List<ComponenteModel> GetComponentes(int idUsuario)
        {
            return ADPersonaManager.GetComponentes(idUsuario);
        }


    }
}
