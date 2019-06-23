using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class CajaChicaManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the Caja_ChicaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(CajaChicaModel aCaja_ChicaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 4);
                    command.Parameters.AddWithValue("@ID", aCaja_ChicaModel.Id);
                    command.Parameters.AddWithValue("@Tipo_Accion", aCaja_ChicaModel.Tipo_Accion);
                    command.Parameters.AddWithValue("@Monto", aCaja_ChicaModel.Monto);
                    command.Parameters.AddWithValue("@Id_TurnoUsuario", aCaja_ChicaModel.Id_TurnoUsuario);
                    command.Parameters.AddWithValue("@Hora", aCaja_ChicaModel.Hora);
                    command.Parameters.AddWithValue("@Fecha", aCaja_ChicaModel.Fecha);
                    command.Parameters.AddWithValue("@USUARIO_CREADOR", aCaja_ChicaModel.Usuario_creador);
                    command.Parameters.AddWithValue("@FECHA_CREACION", aCaja_ChicaModel.Fecha_creacion);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tCajaChica";

                    int afectados = command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();

                    if (afectados > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Updates a record to the Caja_ChicaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(CajaChicaModel aCaja_ChicaModel)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 5);
                    command.Parameters.AddWithValue("@ID", aCaja_ChicaModel.Id);
                    command.Parameters.AddWithValue("@Tipo_Accion", aCaja_ChicaModel.Tipo_Accion);
                    command.Parameters.AddWithValue("@Monto", aCaja_ChicaModel.Monto);
                    command.Parameters.AddWithValue("@Id_TurnoUsuario", aCaja_ChicaModel.Id_TurnoUsuario);
                    command.Parameters.AddWithValue("@Hora", aCaja_ChicaModel.Hora);
                    command.Parameters.AddWithValue("@Fecha", aCaja_ChicaModel.Fecha);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aCaja_ChicaModel.Usuario_modificador == null ? (object)DBNull.Value : aCaja_ChicaModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aCaja_ChicaModel.Fecha_modificacion == null ? (object)DBNull.Value : aCaja_ChicaModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tCajaChica";

                    int afectados = command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();

                    if (afectados > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int aID)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@pMode", 6);
                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tCajaChica";
                    int afectados = command.ExecuteNonQuery();

                    // Commit the transaction.
                    sqlTran.Commit();

                    connection.Close();
                    connection.Dispose();

                    if (afectados > 0)
                        return true;
                    else
                        return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Deletes record to the Caja_ChicaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>

        /// <summary>
        /// Selects the Single object of Caja_ChicaModel table.
        /// </summary>

        /// <summary>
        /// Selects all the objects of Caja_ChicaModel table.
        /// </summary>
        ///
        public CajaChicaModel GetCajaChicaModel(int aID)
        {
            CajaChicaModel GetCajaChicaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_pBanco";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Tipo_Accion = (string)(reader["Tipo_Accion"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            int Id_TurnoUsuario = (int)(reader["Id_TurnoUsuario"]);
                            TimeSpan Hora = (TimeSpan)(reader["Hora"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            GetCajaChicaModel = new CajaChicaModel
                            {
                                Id = ID,
                                Tipo_Accion = Tipo_Accion,
                                Monto = Monto,
                                Id_TurnoUsuario = Id_TurnoUsuario,
                                Hora = Hora,
                                Fecha = Fecha,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            };
                        }
                    }
                }

                return GetCajaChicaModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<CajaChicaModel> Caja_ChicaModelSelectAll()
        {

            List<CajaChicaModel> Caja_ChicaModellist = new List<CajaChicaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pMode", 1);

                    command.CommandText = "sp_tCajaChica";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Tipo_Accion = (string)(reader["Tipo_Accion"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            int Id_TurnoUsuario = (int)(reader["Id_TurnoUsuario"]);
                            TimeSpan Hora = (TimeSpan)(reader["Hora"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            Caja_ChicaModellist.Add(new CajaChicaModel
                            {
                                Id = ID,
                                Tipo_Accion = Tipo_Accion,
                                Monto = Monto,
                                Id_TurnoUsuario = Id_TurnoUsuario,
                                Hora = Hora,
                                Fecha = Fecha,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return Caja_ChicaModellist;
            }
            catch (Exception)
            {
                return Caja_ChicaModellist;
            }
        }


        /// <summary>
        /// Selects the Multiple objects of Caja_ChicaModel table by a given criteria.
        /// </summary>
        public List<CajaChicaModel> Caja_ChicaModelSelectbyUNKNOW(string aValue)
        {

            List<CajaChicaModel> Caja_ChicaModellist = new List<CajaChicaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@UNKNOW", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "Caja_ChicaModelSelectbyUNKNOW";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            string Tipo = (string)(reader["Tipo"]);
                            decimal Monto = (decimal)(reader["Monto"]);
                            int ID_Persona = (int)(reader["ID_Persona"]);
                            TimeSpan Hora = (TimeSpan)(reader["Hora"]);
                            DateTime Fecha = (DateTime)(reader["Fecha"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            Caja_ChicaModellist.Add(new CajaChicaModel
                            {
                                Id = ID,
                                Tipo_Accion = Tipo,
                                Monto = Monto,
                                Id_TurnoUsuario = ID_Persona,
                                Hora = Hora,
                                Fecha = Fecha,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return Caja_ChicaModellist;
            }
            catch (Exception)
            {
                return Caja_ChicaModellist;
            }
        }
        #endregion

    }

}
