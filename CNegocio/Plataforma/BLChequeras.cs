using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Modelos;
using CDatos.Manager;

namespace CNegocio.Plataforma
{
    public class BLChequeras
    {
        ChequerasManager managerChequera = new ChequerasManager();

        #region Methods

        public bool Insert(ChequerasModel achequera)
        {
            achequera.Fin = achequera.Inicio + achequera.Cantidad_cheques;

            return this.managerChequera.Insert(achequera);
        }


        public bool Update(ChequerasModel achequera)
        {
            return this.managerChequera.Update(achequera);
        }



        public bool Delete(int aNumero)
        {
            return this.managerChequera.Delete(aNumero);
        }


        public ChequerasModel GetChequerasModel(int aNumero)
        {
            return this.managerChequera.Getchequera(aNumero);
        }


        public List<ChequerasModel> obtenerTodosCheques()
        {
            return this.managerChequera.chequeraSelectAll();
        }

        public List<ChequerasModel> chequeraSelectbyCuenta(string acuenta)
        {
            return this.managerChequera.chequeraSelectbyCuenta(acuenta);
        }
        #endregion
    }
}

