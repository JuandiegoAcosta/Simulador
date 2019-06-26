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
   public class RetirosManager
    {
        public int RetiroInsert(decimal Monto,int Tarjeta,int Clave)
        {
            int afectados=0;
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;


                    command.Parameters.AddWithValue("@Monto",Monto);
                    command.Parameters.AddWithValue("@Tarjeta",Tarjeta);
                    command.Parameters.AddWithValue("@Clave",Clave);              

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "RetirosInsert";

                    afectados = command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();
                    return afectados;
                }
            }
            catch (Exception)
            {
               
                return afectados;
            }
        }
    }
}
