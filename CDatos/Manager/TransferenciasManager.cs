using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Manager
{
   public class TransferenciasManager
    {

        public int TransferenciaBancaria(CuentasTarjetasModel cuentasTarjetasModel)
        {

            //   List<RecaudosModel> EmpresaModellist = new List<RecaudosModel>();
             int result=-1;
            try
            {          
                /*@Monto Decimal(12,4),
                @Clave int,
                @NroCuenta int,
                 @NroCuentaDestino int,
                 @doi int*/
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Monto", cuentasTarjetasModel.Monto);
                    command.Parameters.AddWithValue("@Clave", cuentasTarjetasModel.clave);
                    command.Parameters.AddWithValue("@NroCuenta", cuentasTarjetasModel.NroCuenta);
                    command.Parameters.AddWithValue("@NroCuentaDestino", cuentasTarjetasModel.NroCuentaDestino);
                    command.Parameters.AddWithValue("@doi", cuentasTarjetasModel.doi);
                    command.Parameters.AddWithValue("@Usuario", "Carlin Yahuira Achahui");
                    
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "TransferenciaInsert";

                    result = command.ExecuteNonQuery();
                
                }

                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

    }
}
