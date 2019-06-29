using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos.Manager;
using Modelos.Modelos;

namespace CNegocio.Plataforma
{
    public class BLCuenta
    {
        CuentaManager cuentaManager = new CuentaManager(); 

        #region Methods

        public bool Crear(CuentasModel aCuentasModel)
        {
            return this.cuentaManager.Insert(aCuentasModel);
        }
        
        public bool Actualizar(CuentasModel aCuentasModel)
        {
            return this.cuentaManager.Update(aCuentasModel);
        }
        
        public CuentasModel ObtenerCuenta(string aNumero)
        {
            return this.cuentaManager.GetCuentasModel(aNumero);
        }

        public List<CuentasModel> ObtenerTodosCuentasUsuario(int aUsuario)
        {
            return this.cuentaManager.CuentasModelSelectByUser(aUsuario);
        }

        #endregion

    }
}
