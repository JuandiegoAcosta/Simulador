using CDatos.Manager;
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
        private PersonaManager ADPersonaManager;

        public PersonaMethods()
        {
            ADPersonaManager = new PersonaManager();
        }
        public bool Crear(PersonaModel aPersona)
        {
            bool exito = false;
            try
            {

                PersonaModel ValidacionUsuario = ValidarUsuario(aPersona.Nombreusuario, aPersona.Pass);
                if (ValidacionUsuario != null)
                {
                    return false;
                }
                else
                {
                    exito = ADPersonaManager.Insert(aPersona);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return exito;
        }

        public bool Editar(PersonaModel aPersona)
        {
            return ADPersonaManager.Update(aPersona);
        }

        public bool Eliminar(int aID_Persona)
        {
            return ADPersonaManager.Delete(aID_Persona);
        }

        public PersonaModel ObtenerUno(int aID_Persona)
        {
            return ADPersonaManager.GetPersonaModel(aID_Persona);
        }

        public List<PersonaModel> ObtenerTodos()
        {
            return ADPersonaManager.PersonaModelSelectAll();
        }

        public bool ValidarUsuario(string aUsuario, string aContraseña)
        {
            return ADPersonaManager.ValidarUsuario(aUsuario, aContraseña);
        }

        public bool CambiarContraseña(string aUsuario, string aContraseña, string aNuevaContraseña)
        {

            return ADPersonaManager.CambiarContraseña(aUsuario, aContraseña, aNuevaContraseña);
        }

    }
}
