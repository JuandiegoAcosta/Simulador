using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos.Modelos;
using CDatos.Manager;

namespace CNegocio.Plataforma
{
    class BLCliente
    {
        PersonaManager personasManager = new PersonaManager();

        #region Methods

        public bool Ingresar(PersonaModel aPersonaModel)
        {
            return this.personasManager.Insert(aPersonaModel);
        }

        public bool Actualizar(PersonaModel aPersonaModel)
        {
            return this.personasManager.Update(aPersonaModel);
        }

        public bool Eliminar(int aNumero)
        {
            return this.personasManager.Delete(aNumero);
        }

        public PersonaModel obtenerCliente(int aNumero)
        {
            return this.personasManager.GetPersonaModel(aNumero);
        }


        /// <summary>
        /// Selects all the objects of ChequesModel table.
        /// </summary>
        public List<PersonaModel> obtenerTodosClientes()
        {
            return this.personasManager.PersonaModelSelectAll();
        }


        //public List<ChequesModel> ChequesModelSelectbyUNKNOW(string aValue)
        //{

        //    List<ChequesModel> ChequesModellist = new List<ChequesModel>();

        //    try
        //    {
        //        using (var connection = Util.ConnectionFactory.conexion())
        //        {
        //            connection.Open();

        //            SqlCommand command = connection.CreateCommand();

        //            command.Parameters.AddWithValue("@UNKNOW", aValue);

        //            command.CommandType = CommandType.StoredProcedure;

        //            command.CommandText = "ChequesModelSelectbyUNKNOW";

        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.HasRows)
        //            {
        //                while (reader.Read())
        //                {

        //                    int Numero = (int)(reader["Numero"]);
        //                    DateTime FechaEmision = (DateTime)(reader["FechaEmision"]);
        //                    DateTime? FechaCobro = reader["FechaCobro"] as DateTime?;
        //                    string Destinatario = (string)(reader["Destinatario"]);
        //                    decimal Monto = (decimal)(reader["Monto"]);
        //                    int IDChequesModelra = (int)(reader["IDChequesModelra"]);
        //                    string Estado = (string)(reader["Estado"]);
        //                    DateTime FECHA_CREACION = (DateTime)(reader["FECHA_CREACION"]);
        //                    DateTime? FECHA_MODIFICACION = reader["FECHA_MODIFICACION"] as DateTime?;
        //                    string USUARIO_CREACION = (string)(reader["USUARIO_CREACION"]);
        //                    string USUARIO_MODIFICADOR = (string)(reader["USUARIO_MODIFICADOR"]);

        //                    ChequesModellist.Add(new ChequesModel
        //                    {
        //                        Numero = Numero,
        //                        Fechaemision = FechaEmision,
        //                        Fechacobro = FechaCobro,
        //                        Destinatario = Destinatario,
        //                        Monto = Monto,
        //                        //IdChequesModelra = IDChequesModelra,
        //                        Estado = Estado,
        //                        Fecha_creacion = FECHA_CREACION,
        //                        Fecha_modificacion = FECHA_MODIFICACION,
        //                        Usuario_creacion = USUARIO_CREACION,
        //                        Usuario_modificador = USUARIO_MODIFICADOR,

        //                    });
        //                }
        //            }
        //        }

        //        return ChequesModellist;
        //    }
        //    catch (Exception)
        //    {
        //        return ChequesModellist;
        //    }
        //}
        #endregion
    }
}
