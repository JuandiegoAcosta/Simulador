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
    public class DepositoManager
    {
        public bool Insert(Deposito Dep)
        {
            
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@NroCuenta", Dep.NroCuenta);
                    command.Parameters.AddWithValue("@Monto", Dep.Monto);
                    command.Parameters.AddWithValue("@doi", Dep.Doi);
                    command.Parameters.AddWithValue("@Usuario", Dep.Usuario= "Carlin Yahuira Achahui");


                command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DepositosInsert";

                     command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();

                    //if (afectados > 0)
                        return true;
                    //else
                    //    return false;
                }
           
        }
    }
}
