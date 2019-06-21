using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Modelos;
using CDatos.Manager;

namespace CNegocio.Plataforma
{
    public class BLPersona
    {
        PersonaManager personaManager = new PersonaManager();

        #region Methods

        public bool Ingresar(PersonaModel aPersonaModel)
        {
            return this.personaManager.Insert(aPersonaModel);
        }


        public bool Actualizar(PersonaModel aPersonaModel)
        {
            return this.personaManager.Update(aPersonaModel);
        }

        
        public bool Eliminar(int aNumero)
        {
            return this.personaManager.Delete(aNumero);
        }


        public PersonaModel obtenerPersona(int numeroDocumento, int tipoDocumento)
        {
            return this.personaManager.GetPersonaModel(numeroDocumento, tipoDocumento);
        }



        #endregion

    }
}
