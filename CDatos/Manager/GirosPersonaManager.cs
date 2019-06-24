using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos.Manager
{
   public class GirosPersonaManager
    {
        public List<object> SelectGirosbyDocClave(string aValue,Int16 clave)
        {

            List<object> Giros = new List<object>();

            using (var connection = Util.ConnectionFactory.conexion())
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();

                command.Parameters.AddWithValue("@NroDocumento", aValue);
                command.Parameters.AddWithValue("@Clave", clave);

                command.CommandType = CommandType.StoredProcedure;

                command.CommandText = "GiroPerosonaSelectByDocClave";

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Giros.Add(new
                        {
                            Origen = reader[0],
                            Destino = reader[1],
                            Monto = reader[2],
                            FechaGiro = reader[3],
                            FechaRetiro = reader[4],
                            Estado = reader[5]
                        });
                    }
                }
            }
            return Giros;
        }
    }
}
