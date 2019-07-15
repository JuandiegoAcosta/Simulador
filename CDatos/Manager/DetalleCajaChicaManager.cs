﻿using Modelos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CDatos.Manager
{
    public class DetalleCajaChicaManager
    {

        #region Methods
        /// <summary>
        /// Saves a record to the Caja_ChicaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(DetalleCajaChicaModel aDetalleCajaChicaModel)
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
                    command.Parameters.AddWithValue("@ID", aDetalleCajaChicaModel.Id);
                    command.Parameters.AddWithValue("@Id_CajaChica", aDetalleCajaChicaModel.Id_CajaChica);
                    command.Parameters.AddWithValue("@Denominacion", aDetalleCajaChicaModel.Denominacion);
                    command.Parameters.AddWithValue("@Cantidad", aDetalleCajaChicaModel.Cantidad);
                    command.Parameters.AddWithValue("@Moneda", aDetalleCajaChicaModel.Moneda);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tDetalleCajaChica";

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
        public bool Update(DetalleCajaChicaModel aDetalleCajaChicaModel)
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
                    command.Parameters.AddWithValue("@ID", aDetalleCajaChicaModel.Id);
                    command.Parameters.AddWithValue("@Id_CajaChica", aDetalleCajaChicaModel.Id_CajaChica);
                    command.Parameters.AddWithValue("@Denominacion", aDetalleCajaChicaModel.Denominacion);
                    command.Parameters.AddWithValue("@Cantidad", aDetalleCajaChicaModel.Cantidad);
                    command.Parameters.AddWithValue("@Moneda", aDetalleCajaChicaModel.Moneda);
                    command.Parameters.AddWithValue("@USUARIO_MODIFICADOR", aDetalleCajaChicaModel.Usuario_modificador == null ? (object)DBNull.Value : aDetalleCajaChicaModel.Usuario_modificador);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", aDetalleCajaChicaModel.Fecha_modificacion == null ? (object)DBNull.Value : aDetalleCajaChicaModel.Fecha_modificacion);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tDetalleCajaChica";

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
                    command.CommandText = "sp_tDetalleCajaChica";
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
        /// Selects all the objects of Caja_ChicaModel table.
        /// </summary>
        ///
        public DetalleCajaChicaModel GetDetalleCajaChicaModel(int aID)
        {
            DetalleCajaChicaModel GetDetalleCajaChicaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);
                    command.Parameters.AddWithValue("@ID", aID);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tDetalleCajaChica";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            int Id_CajaChica = (int)(reader["Id_CajaChica"]);
                            decimal Denominacion = (decimal)(reader["Denominacion"]);
                            int Cantidad = (int)(reader["Cantidad"]);
                            string Moneda = (string)(reader["Moneda"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            GetDetalleCajaChicaModel = new DetalleCajaChicaModel
                            {
                                Id = ID,
                                Id_CajaChica = Id_CajaChica,
                                Denominacion = Denominacion,
                                Cantidad = Cantidad,
                                Moneda = Moneda,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            };
                        }
                    }
                }

                return GetDetalleCajaChicaModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<DetalleCajaChicaModel> Caja_ChicaModelSelectAll()
        {

            List<DetalleCajaChicaModel> DetalleCajaChicaModellist = new List<DetalleCajaChicaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@pMode", 1);

                    command.CommandText = "sp_tDetalleCajaChica";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int ID = (int)(reader["ID"]);
                            int Id_CajaChica = (int)(reader["Id_CajaChica"]);
                            decimal Denominacion = (decimal)(reader["Denominacion"]);
                            int Cantidad = (int)(reader["Cantidad"]);
                            string Moneda = (string)(reader["Moneda"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            DetalleCajaChicaModellist.Add(new DetalleCajaChicaModel
                            {
                                Id = ID,
                                Id_CajaChica = Id_CajaChica,
                                Denominacion = Denominacion,
                                Cantidad = Cantidad,
                                Moneda = Moneda,
                                Usuario_creador = USUARIO_CREADOR,
                                Fecha_creacion = FECHA_CREACION,
                                Usuario_modificador = USUARIO_MODIFICADOR,
                                Fecha_modificacion = FECHA_MODIFICACION,

                            });
                        }
                    }
                }

                return DetalleCajaChicaModellist;
            }
            catch (Exception)
            {
                return DetalleCajaChicaModellist;
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
                            int ID_Persona = (int)(reader["ID_Persona"]);
                            TimeSpan Cantidad = (TimeSpan)(reader["Cantidad"]);
                            string USUARIO_CREADOR = (string)(reader["USUARIO_CREADOR"]);
                            DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
                            string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);
                            DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;

                            Caja_ChicaModellist.Add(new CajaChicaModel
                            {
                                Id = ID,
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
