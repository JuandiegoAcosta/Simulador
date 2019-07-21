using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Manager
{
    public class CuotasPrestamosManager
    {
        //PrestamosSelect_NroCuenta
        public List<object> CuotasPrestamosSelect(string aValue)
        {

            List<object> Prestamos = new List<object>();

          
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Dni", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PrestamosSelect_NroCuenta";
          
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                        //   int Nro_cuenta = (int)(reader[0]);
                        //   DateTime SaldoContable = (DateTime)(reader[1]);
                        //   decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
                        //  string TipoCuenta = (string)(reader["TipoCuenta"]);
                        //  string Moneda = (string)(reader["Moneda"]);

                        /*ID	FechaPrestamo	MontoPrestamo	Moneda	PlazoMeses	Interes	Descripcion	Interes_Moratorio	DiaPago
*/
                        Prestamos.Add(new
                            {
                            Codigo = reader[0],
                            FechaPrestamo = reader[1],
                            MontoPrestamo = reader[2],
                            Moneda = reader[3],
                            PlazoMeses = reader[4],
                            Interes = reader[5],
                            Descripcion = reader[6],
                            Interes_Moratorio = reader[7],
                            DiaPago = reader[8]
                        });
                        }
                    }
                }

                return Prestamos;
            
           
        }

        public int CuotasInsert(object cuotaID, object usuario)
        {
            throw new NotImplementedException();
        }

        public List<object> CuotasSelect(int aValue)
        {

            List<object> cuotas = new List<object>();


            using (var connection = Util.ConnectionFactory.conexion())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.Parameters.AddWithValue("@ID", aValue);

                command.CommandType = CommandType.StoredProcedure;

                command.CommandText = "SelectCuotasID";

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        cuotas.Add(new
                        {
                            //someBool ? "true" : "false";
                            Codigo = reader[0],
                            Cuota = reader[1],
                            Monto = reader[2],
                            Estado = reader[3]
                        });
                    }
                }
            }

            return cuotas;


        }
        //CronogramaPagosInsertById
        public int CuotasInsert(int CuotaID,string Usuario)
        {

            //  List<object> cuotas = new List<object>();

            int reader;
            using (var connection = Util.ConnectionFactory.conexion())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.Parameters.AddWithValue("@Cuota", CuotaID);
                command.Parameters.AddWithValue("@Usuario", Usuario);

                command.CommandType = CommandType.StoredProcedure;

                command.CommandText = "CronogramaPagosInsertById";

                reader = command.ExecuteNonQuery();

            }

            return reader;


        }
       

    }
}
