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

                    command.Parameters.AddWithValue("@NroCuenta", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PrestamosSelect_NroCuenta";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            string Nro_cuenta = (string)(reader["Nrocuenta"]);
                            decimal SaldoContable = (decimal)(reader["SaldoContable"]);
                            decimal SaldoDisponible = (decimal)(reader["SaldoDisponible"]);
                            string TipoCuenta = (string)(reader["TipoCuenta"]);
                            string Moneda = (string)(reader["Moneda"]);
      

                            Prestamos.Add(new
                            {
                                Nro_cuenta,
                                SaldoContable,
                                SaldoDisponible,
                                TipoCuenta,
                                Moneda

                            });
                        }
                    }
                }

                return Prestamos;
            
           
        }

    }
}
