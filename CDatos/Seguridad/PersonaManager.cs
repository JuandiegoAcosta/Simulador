﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Modelos;

namespace CDatos.Manager
{
    public class PersonaManager
    {
        #region Methods
        /// <summary>
        /// Saves a record to the PersonaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>		
        public bool Insert(PersonaModel apersona)
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
                    command.Parameters.AddWithValue("@NombreUsuario", apersona.Nombreusuario == null ? (object)DBNull.Value : apersona.Nombreusuario);
                    command.Parameters.AddWithValue("@Pass", apersona.Pass == null ? (object)DBNull.Value : apersona.Pass);
                    command.Parameters.AddWithValue("@Correo", apersona.Correo == null ? (object)DBNull.Value : apersona.Correo);
                    command.Parameters.AddWithValue("@Estado", apersona.Estado);
                    command.Parameters.AddWithValue("@Nombres", apersona.Nombres);
                    command.Parameters.AddWithValue("@Apellidos", apersona.Apellidos);
                    command.Parameters.AddWithValue("@FechaNacimiento", apersona.Fechanacimiento);
                    command.Parameters.AddWithValue("@Telefono", apersona.Telefono == null ? (object)DBNull.Value : apersona.Telefono);
                    command.Parameters.AddWithValue("@NroDocumento", apersona.Nrodocumento);
                    command.Parameters.AddWithValue("@TipoDocumento", apersona.Tipodocumento);
                    command.Parameters.AddWithValue("@Tipo_Persona", apersona.Tipo_persona == null ? (object)DBNull.Value : apersona.Tipo_persona);
                    command.Parameters.AddWithValue("@Usuario_creador", apersona.Usuario_creador);
                    command.Parameters.AddWithValue("@Usuario_modificador", apersona.Usuario_modificador == null ? (object)DBNull.Value : apersona.Usuario_modificador);

                    SqlParameter paramId = new SqlParameter("@IDENTITY", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    command.Parameters.Add(paramId);

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tPersona";

                    int identity = Convert.ToInt32(command.Parameters["@IDENTITY"].Value.ToString());
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
                //throw;
                return false;
            }
        }


        /// <summary>
        /// Updates a record to the PersonaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Update(PersonaModel apersona)
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
                    command.Parameters.AddWithValue("@Id", apersona.Id);
                    command.Parameters.AddWithValue("@NombreUsuario", apersona.Nombreusuario == null ? (object)DBNull.Value : apersona.Nombreusuario);
                    command.Parameters.AddWithValue("@Pass", apersona.Pass == null ? (object)DBNull.Value : apersona.Pass);
                    command.Parameters.AddWithValue("@Correo", apersona.Correo == null ? (object)DBNull.Value : apersona.Correo);
                    command.Parameters.AddWithValue("@Estado", apersona.Estado);
                    command.Parameters.AddWithValue("@Nombres", apersona.Nombres);
                    command.Parameters.AddWithValue("@Apellidos", apersona.Apellidos);
                    command.Parameters.AddWithValue("@FechaNacimiento", apersona.Fechanacimiento);
                    command.Parameters.AddWithValue("@Telefono", apersona.Telefono == null ? (object)DBNull.Value : apersona.Telefono);
                    command.Parameters.AddWithValue("@NroDocumento", apersona.Nrodocumento);
                    command.Parameters.AddWithValue("@TipoDocumento", apersona.Tipodocumento);
                    command.Parameters.AddWithValue("@Tipo_Persona", apersona.Tipo_persona == null ? (object)DBNull.Value : apersona.Tipo_persona);
                    command.Parameters.AddWithValue("@Usuario_creador", apersona.Usuario_creador);
                    command.Parameters.AddWithValue("@Usuario_modificador", apersona.Usuario_modificador == null ? (object)DBNull.Value : apersona.Usuario_modificador);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tPersona";

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
        /// Deletes record to the PersonaModel table.
        /// returns True if value saved successfully else false
        /// Throw exception with message value EXISTS if the data is duplicate
        /// </summary>
        public bool Delete(int aId)
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
                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_tPersona";
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
        /// Selects the Single object of PersonaModel table.
        /// </summary>
        public PersonaModel GetPersonaModel(int aId)
        {
            PersonaModel PersonaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 2);

                    command.Parameters.AddWithValue("@Id", aId);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tPersona";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        int Id = (int)(reader["Id"]);
                        string NombreUsuario = (string)(reader["NombreUsuario"]);
                        string Pass = (string)(reader["Pass"]);
                        string Correo = (reader["Correo"]) == DBNull.Value ? null : (string)(reader["Correo"]);
                        bool Estado = (bool)(reader["Estado"]);
                        string Nombres = (string)(reader["Nombres"]);
                        string Apellidos = (string)(reader["Apellidos"]);
                        DateTime FechaNacimiento = (DateTime)(reader["FechaNacimiento"]);
                        string Telefono = (reader["Telefono"]) == DBNull.Value ? null : (string)(reader["Telefono"]);
                        string NroDocumento = (string)(reader["NroDocumento"]);
                        int TipoDocumento = (int)(reader["TipoDocumento"]);
                        string Tipo_Persona = (reader["Tipo_Persona"]) == DBNull.Value ? null : (string)(reader["Tipo_Persona"]);
                        //8
                        PersonaModel = new PersonaModel
                        {
                            Id = Id,
                            Nombreusuario = NombreUsuario,
                            Pass = Pass,
                            Correo = Correo,
                            Estado = Estado,
                            Nombres = Nombres,
                            Apellidos = Apellidos,
                            Fechanacimiento = FechaNacimiento,
                            Telefono = Telefono,
                            Nrodocumento = NroDocumento,
                            Tipodocumento = TipoDocumento,
                            Tipo_persona = Tipo_Persona,
                        };
                    }
                }

                return PersonaModel;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Selects all the objects of PersonaModel table.
        /// </summary>
        public List<PersonaModel> PersonaModelSelectAll()
        {

            List<PersonaModel> PersonaModellist = new List<PersonaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@pMode", 1);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_tPersona";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string NombreUsuario = (string)(reader["NombreUsuario"]);
                            string Pass = (string)(reader["Pass"]);
                            string Correo = (reader["Correo"]) == DBNull.Value ? null : (string)(reader["Correo"]);
                            bool Estado = (bool)(reader["Estado"]);
                            string Nombres = (string)(reader["Nombres"]);
                            string Apellidos = (string)(reader["Apellidos"]);
                            DateTime FechaNacimiento = (DateTime)(reader["FechaNacimiento"]);
                            string Telefono = (reader["Telefono"]) == DBNull.Value ? null : (string)(reader["Telefono"]);
                            string NroDocumento = (string)(reader["NroDocumento"]);
                            int TipoDocumento = (int)(reader["TipoDocumento"]);
                            string Tipo_Persona = (reader["Tipo_Persona"]) == DBNull.Value ? null : (string)(reader["Tipo_Persona"]);

                            PersonaModellist.Add(new PersonaModel
                            {
                                Id = Id,
                                Nombreusuario = NombreUsuario,
                                Pass = Pass,
                                Correo = Correo,
                                Estado = Estado,
                                Nombres = Nombres,
                                Apellidos = Apellidos,
                                Fechanacimiento = FechaNacimiento,
                                Telefono = Telefono,
                                Nrodocumento = NroDocumento,
                                Tipodocumento = TipoDocumento,
                                Tipo_persona = Tipo_Persona,

                            });
                        }
                    }
                }

                return PersonaModellist;
            }
            catch (Exception)
            {
                return PersonaModellist;
            }
        }

        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyID(string aValue)
        {

            List<PersonaModel> personalist = new List<PersonaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Id", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "personaSelectbyId";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string NombreUsuario = reader["NombreUsuario"] as string;
                            string Pass = reader["Pass"] as string;
                            string Correo = (reader["Correo"]) == DBNull.Value ? null : (string)(reader["Correo"]);
                            bool Estado = (bool)(reader["Estado"]);
                            string Nombres = (string)(reader["Nombres"]);
                            string Apellidos = (string)(reader["Apellidos"]);
                            DateTime FechaNacimiento = (DateTime)(reader["FechaNacimiento"]);
                            string Telefono = (reader["Telefono"]) == DBNull.Value ? null : (string)(reader["Telefono"]);
                            string NroDocumento = (string)(reader["NroDocumento"]);
                            int TipoDocumento = (int)(reader["TipoDocumento"]);
                            string Tipo_Persona = (reader["Tipo_Persona"]) == DBNull.Value ? null : (string)(reader["Tipo_Persona"]);

                            personalist.Add(new PersonaModel
                            {
                                Id = Id,
                                Nombreusuario = NombreUsuario,
                                Pass = Pass,
                                Correo = Correo,
                                Estado = Estado,
                                Nombres = Nombres,
                                Apellidos = Apellidos,
                                Fechanacimiento = FechaNacimiento,
                                Telefono = Telefono,
                                Nrodocumento = NroDocumento,
                                Tipodocumento = TipoDocumento,
                                Tipo_persona = Tipo_Persona,

                            });
                        }
                    }
                }

                return personalist;
            }
            catch (Exception)
            {
                return personalist;
            }
        }

        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyNombres(string aValue)
        {

            List<PersonaModel> personalist = new List<PersonaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Nombres", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PersonaSelectbyNombre";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {


                            int Id = (int)(reader["Id"]);
                            string NombreUsuario = reader["NombreUsuario"] as string;
                            string Pass = reader["Pass"] as string;
                            string Correo = (reader["Correo"]) == DBNull.Value ? null : (string)(reader["Correo"]);
                            bool Estado = (bool)(reader["Estado"]);
                            string Nombres = (string)(reader["Nombres"]);
                            string Apellidos = (string)(reader["Apellidos"]);
                            DateTime FechaNacimiento = (DateTime)(reader["FechaNacimiento"]);
                            string Telefono = (reader["Telefono"]) == DBNull.Value ? null : (string)(reader["Telefono"]);
                            string NroDocumento = (string)(reader["NroDocumento"]);
                            int TipoDocumento = (int)(reader["TipoDocumento"]);
                            string Tipo_Persona = (reader["Tipo_Persona"]) == DBNull.Value ? null : (string)(reader["Tipo_Persona"]);

                            personalist.Add(new PersonaModel
                            {
                                Id = Id,
                                Nombreusuario = NombreUsuario,
                                Pass = Pass,
                                Correo = Correo,
                                Estado = Estado,
                                Nombres = Nombres,
                                Apellidos = Apellidos,
                                Fechanacimiento = FechaNacimiento,
                                Telefono = Telefono,
                                Nrodocumento = NroDocumento,
                                Tipodocumento = TipoDocumento,
                                Tipo_persona = Tipo_Persona,

                            });
                        }
                    }
                }

                return personalist;
            }
            catch (Exception)
            {
                //throw;
                return personalist;
            }
        }

        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyApellidos(string aValue)
        {

            List<PersonaModel> personalist = new List<PersonaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Apellidos", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PersonaSelectbyApellidos";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string NombreUsuario = reader["NombreUsuario"] as string;
                            string Pass = reader["Pass"] as string;
                            string Correo = (string)(reader["Correo"]);
                            bool Estado = (bool)(reader["Estado"]);
                            string Nombres = (string)(reader["Nombres"]);
                            string Apellidos = (string)(reader["Apellidos"]);
                            DateTime FechaNacimiento = (DateTime)(reader["FechaNacimiento"]);
                            string Telefono = (string)(reader["Telefono"]);
                            string NroDocumento = (string)(reader["NroDocumento"]);
                            int TipoDocumento = (int)(reader["TipoDocumento"]);
                            string Tipo_Persona = (string)(reader["Tipo_Persona"]);

                            personalist.Add(new PersonaModel
                            {
                                Id = Id,
                                Nombreusuario = NombreUsuario,
                                Pass = Pass,
                                Correo = Correo,
                                Estado = Estado,
                                Nombres = Nombres,
                                Apellidos = Apellidos,
                                Fechanacimiento = FechaNacimiento,
                                Telefono = Telefono,
                                Nrodocumento = NroDocumento,
                                Tipodocumento = TipoDocumento,
                                Tipo_persona = Tipo_Persona,

                            });
                        }
                    }
                }

                return personalist;
            }
            catch (Exception)
            {
                return personalist;
            }
        }

        /// <summary>
        /// Selects the Multiple objects of persona table by a given criteria.
        /// </summary>
        public List<PersonaModel> personaSelectbyNroDocumento(string aValue)
        {

            List<PersonaModel> personalist = new List<PersonaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@NroDocumento", aValue);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "PersonaSelectbyNroDocumento";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string NombreUsuario = reader["NombreUsuario"] as string;
                            string Pass = reader["Pass"] as string;
                            string Correo = (reader["Correo"]) == DBNull.Value ? null : (string)(reader["Correo"]);
                            bool Estado = (bool)(reader["Estado"]);
                            string Nombres = (string)(reader["Nombres"]);
                            string Apellidos = (string)(reader["Apellidos"]);
                            DateTime FechaNacimiento = (DateTime)(reader["FechaNacimiento"]);
                            string Telefono = (reader["Telefono"]) == DBNull.Value ? null : (string)(reader["Telefono"]);
                            string NroDocumento = (string)(reader["NroDocumento"]);
                            int TipoDocumento = (int)(reader["TipoDocumento"]);
                            string Tipo_Persona = (reader["Tipo_Persona"]) == DBNull.Value ? null : (string)(reader["Tipo_Persona"]);

                            personalist.Add(new PersonaModel
                            {
                                Id = Id,
                                Nombreusuario = NombreUsuario,
                                Pass = Pass,
                                Correo = Correo,
                                Estado = Estado,
                                Nombres = Nombres,
                                Apellidos = Apellidos,
                                Fechanacimiento = FechaNacimiento,
                                Telefono = Telefono,
                                Nrodocumento = NroDocumento,
                                Tipodocumento = TipoDocumento,
                                Tipo_persona = Tipo_Persona,

                            });
                        }
                    }
                }

                return personalist;
            }
            catch (Exception)
            {
                //throw;
                return personalist;
            }
        }

        /// <summary>
        /// Validacion de la existencia del usuario
        /// </summary>

        public PersonaModel ValidarUsuario(string usuario, string password)
        {
            PersonaModel PersonaModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();

                    command.CommandText = "sp_ValidaUsuario";
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        int Id = (int)(reader["Id"]);
                        string NombreUsuario = (string)(reader["NombreUsuario"]);
                        string Pass = (string)(reader["Pass"]);
                        string Correo = (reader["Correo"]) == DBNull.Value ? null : (string)(reader["Correo"]);
                        bool Estado = (bool)(reader["Estado"]);
                        string Nombres = (string)(reader["Nombres"]);
                        string Apellidos = (string)(reader["Apellidos"]);
                        DateTime FechaNacimiento = (DateTime)(reader["FechaNacimiento"]);
                        string Telefono = (reader["Telefono"]) == DBNull.Value ? null : (string)(reader["Telefono"]);
                        string NroDocumento = (string)(reader["NroDocumento"]);
                        int TipoDocumento = (int)(reader["TipoDocumento"]);
                        string Tipo_Persona = (reader["Tipo_Persona"]) == DBNull.Value ? "" : (string)(reader["Tipo_Persona"]);

                        PersonaModel = new PersonaModel
                        {
                            Id = Id,
                            Nombreusuario = NombreUsuario,
                            Pass = Pass,
                            Correo = Correo,
                            Estado = Estado,
                            Nombres = Nombres,
                            Apellidos = Apellidos,
                            Fechanacimiento = FechaNacimiento,
                            Telefono = Telefono,
                            Nrodocumento = NroDocumento,
                            Tipodocumento =TipoDocumento,
                            Tipo_persona = Tipo_Persona,
                        };
                    }
                    return PersonaModel;
                }
            }
            catch (Exception ex)
            {
                return PersonaModel;
            }

        }


        public bool CambiarContraseña(string Usuario, string Password, string NewPassword)
        {
            //int acceso = 0;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandText = "spCambiarContrasena";

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Usuario", Usuario);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@NewPassword", NewPassword);

                    command.Parameters.AddWithValue("@afectados", SqlDbType.Int).Direction = ParameterDirection.Output;

                    //SqlDataReader reader = command.ExecuteReader();
                    command.ExecuteNonQuery();

                    int afectado = Convert.ToInt32(command.Parameters["@afectados"].Value.ToString());

                    connection.Close();
                    if (afectado > 0)
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
        /// Obtiene la sucursal del usuario
        /// </summary>
        public Modelos.Modelos.SucursalModel ObtenerSucursal(int idUsuario)
        {
            SucursalModel SucursalModel = null;

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@Id", idUsuario);


                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "spSucursalUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Ubicacion = (string)(reader["Ubicacion"]);
                            int IdBanco = (int)(reader["IdBanco"]);

                            SucursalModel = new SucursalModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Ubicacion = Ubicacion,
                                Idbanco = IdBanco,

                            };
                        }
                    }
                }

                return SucursalModel;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// DEvuelve todos los componenetes de acuerdo al id del usuario
        /// </summary>
        public List<ComponenteModel> GetComponentes(int idUsuario)
        {

            List<ComponenteModel> ComponenteModellist = new List<ComponenteModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@id", idUsuario);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_ObtenerComponentesUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombre = (string)(reader["Nombre"]);
                            string Descripcion = (string)(reader["Descripcion"]);
                            int? Id_aplicacion = reader["Id_aplicacion"] as int?;
                            bool Estado = (bool)(reader["Estado"]);
                            string Codigo = (string)(reader["Codigo"]);
                            int? IdPadre = reader["IdPadre"] as int?;

                            ComponenteModellist.Add(new ComponenteModel
                            {
                                Id = Id,
                                Nombre = Nombre,
                                Descripcion = Descripcion,
                                Id_aplicacion = Id_aplicacion,
                                Estado = Estado,
                                Codigo = Codigo,
                                IdPadre = IdPadre,

                            });
                        }
                    }
                }

                return ComponenteModellist;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Devuelve todos los roles del usuario de acuerdo a su nombre de usuario
        /// </summary>
        public List<RolesModel> GetRolesUsuario(string Usuario)
        {

            List<RolesModel> RolModellist = new List<RolesModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@usuario", Usuario);

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_ObtenerRolesUsuario";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Descripcion = (string)(reader["Descripcion"]);


                            RolModellist.Add(new RolesModel
                            {
                                Id = Id,
                                Descripcion = Descripcion,

                            });
                        }
                    }
                }

                return RolModellist;
            }
            catch (Exception ex)
            {
                return null;
            }
        }







        public DataTable GetPersonasPorRol(int idRol)
        {

            DataTable rolespersona = new DataTable("PersonaRoles");


            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.Parameters.AddWithValue("@idrol", idRol);
                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_ObtenerPersonasPorRol";


                    SqlDataAdapter daLugares = new SqlDataAdapter(command);
                    daLugares.Fill(rolespersona);


                }


                return rolespersona;
            }
            catch (Exception ex)
            {
                return rolespersona;
            }
        }
















        //public List<PersonaModel> asdad(int idRol)
        //{

        //    List<PersonaModel> PersonaPorRolModellist = new List<PersonaModel>();

        //    try
        //    {
        //        using (var connection = Util.ConnectionFactory.conexion())
        //        {
        //            connection.Open();

        //            SqlCommand command = connection.CreateCommand();

        //            command.Parameters.AddWithValue("@idrol", idRol);

        //            command.CommandType = CommandType.StoredProcedure;

        //            command.CommandText = "sp_ObtenerPersonasPorRol";

        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {
        //                    int Id = (int)(reader["Id"]);
                            
        //                    string Nombres = (string)(reader["Nombres"]);
        //                    string NombreUsuario = (string)(reader["NombreUsuario"]);
                            
                     
        //                    bool Estado = (bool)(reader["Estado"]);


        //                    PersonaPorRolModellist.Add(new PersonaModel
        //                    {
        //                        Id = Id,
        //                        Nombres = Nombres,
                               
        //                        Nombreusuario = NombreUsuario,
                                
        //                        Estado = Estado,


        //                    });
        //                }
        //            }
        //        }

        //        return PersonaPorRolModellist;
        //    }
        //    catch (Exception ex)
        //    {
        //        return null;
        //    }
        //}


        public List<PersonaModel> GetPersonaNombreApellidos(string nombre, string apellido)
        {
            List<PersonaModel> PersonaModel = new List<PersonaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();
                    SqlCommand command = connection.CreateCommand();

                    command.CommandText = "sp_ObtenerPersonasPorNombresApellidos";
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@nombres", nombre);
                    command.Parameters.AddWithValue("@apellidos", apellido);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string Nombres = (string)(reader["Nombres"]);
                            string NombreUsuario = (string)(reader["NombreUsuario"]);
                            string NroDocumento = (string)(reader["NroDocumento"]);
                        string TipoDocumento = (string)(reader["Descripcion"].ToString());



                            PersonaModel.Add(new PersonaModel
                            {
                                Id = Id,
                                Nombreusuario = NombreUsuario,
                                Nombres = Nombres,
                                Nrodocumento = NroDocumento,
                                Apellidos = TipoDocumento,

                            });
                        }
                    }
                }

                return PersonaModel;
            }
            catch (Exception ex)
            {
                return null;
            }

        }






        public bool CrearNuevoUsuario(int idPersona, string Usuario, string Contraseña, bool Estado)
        {
            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlTransaction sqlTran = connection.BeginTransaction();

                    SqlCommand command = connection.CreateCommand();

                    command.Transaction = sqlTran;

                    command.Parameters.AddWithValue("@IDPersona", idPersona);
                    command.Parameters.AddWithValue("@Usuario", Usuario);
                    command.Parameters.AddWithValue("@Password", Contraseña); 
                    command.Parameters.AddWithValue("@Estado", Estado);
                    command.Parameters.AddWithValue("@FECHA_CREACION", DateTime.Now);
                    command.Parameters.AddWithValue("@FECHA_MODIFICACION", DateTime.Now);
                   


                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "sp_CrearNuevoUsuario";

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
            catch (Exception ex)
            {
                return false;
            }
        }


        public List<PersonaModel> UsuarioSelectAll()
        {

            List<PersonaModel> listaUsuarios = new List<PersonaModel>();

            try
            {
                using (var connection = Util.ConnectionFactory.conexion())
                {
                    connection.Open();

                    SqlCommand command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;

                    command.CommandText = "sp_ObtenerUsuarios";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            int Id = (int)(reader["Id"]);
                            string NombreUsuario = (string)(reader["NombreUsuario"]);               
                            string Correo = (reader["Correo"]) == DBNull.Value ? null : (string)(reader["Correo"]);
                            string Nombres = (string)(reader["Nombres"]);
                            string Apellidos = (string)(reader["Apellidos"]);
                            bool Estado = (bool)(reader["Estado"]);


                            listaUsuarios.Add(new PersonaModel
                            {
                                Id = Id,
                                Nombreusuario = NombreUsuario,
                                
                                Correo = Correo,
                                Estado = Estado,
                                Nombres = Nombres,
                                Apellidos = Apellidos
                               

                            });
                        }
                    }
                }

                return listaUsuarios;
            }
            catch (Exception)
            {
                return listaUsuarios;
            }
        }



        #endregion

    }

}