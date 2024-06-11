using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionUI.SistemaGestionEntities;

namespace SistemaGestionUI.SistemaGestionData
{
    public class VentaData
    {

        public static Venta ObtenerVenta(int Id)
        {


            GestionBaseDeDatos db = new GestionBaseDeDatos();


            string query = "SELECT Id, Comentarios, IdUsuario FROM Venta WHERE Id=@Id;";


            using (SqlConnection conexion = new SqlConnection(db.connectionString))
            {
                conexion.Open();
                // se usa el comando que esta asociada a la query conectada a la conexion
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var Resultado = new SqlParameter();
                    Resultado.ParameterName = "Id";
                    Resultado.SqlDbType = SqlDbType.Int;
                    Resultado.Value = Id;
                    comando.Parameters.Add(Resultado);

                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var Venta = new Venta();

                                Venta.Id = Convert.ToInt32(dataReader["Id"]);
                                Venta.Comentarios = Convert.ToString(dataReader["Comentarios"]);
                                Venta.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);

                                return Venta;
                            }
                        }

                    }
                    throw new Exception("Id no fue encontrado");
                }
                conexion.Close();
            }
        }

        public static List<Venta> ListarVenta()
        {

            List<Venta> lista1 = new List<Venta>();

            GestionBaseDeDatos db = new GestionBaseDeDatos();


            string query = "SELECT Id, Comentarios, IdUsuario from Venta";

            using (SqlConnection conexion = new SqlConnection(db.connectionString))
            {
                conexion.Open();
                // se usa el comando que esta asociada a la query conectada a la conexion
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var Venta = new Venta();

                                Venta.Id = Convert.ToInt32(dataReader["Id"]);
                                Venta.Comentarios = Convert.ToString(dataReader["Comentarios"]);
                                Venta.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);
                                lista1.Add(Venta);

                            }
                        }

                    }
                }
                conexion.Close();
            }

            return lista1;
        }

        public static void CrearVenta(Venta venta)
        {

            GestionBaseDeDatos db = new GestionBaseDeDatos();


            string query = "INSERT INTO Venta (Comentarios, IdUsuario) " +
                "VALUES (@Comentarios, @IdUsuario);";

                using (SqlConnection conexion = new SqlConnection(db.connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = venta.Id });
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = venta.IdUsuario });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {

                        }
                    }
                    conexion.Close();
                }

        }

        public static void ModificarVenta(int idVenta, Venta venta)
        {
            GestionBaseDeDatos db = new GestionBaseDeDatos();


            string query = "UPDATE Venta SET Comentarios=@Comentarios, IdUsuario=@IdUsuario" +
                " WHERE Id=@Id";

                using (SqlConnection conexion = new SqlConnection(db.connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        var Resultado = new SqlParameter();
                        Resultado.ParameterName = "Id";
                        Resultado.SqlDbType = SqlDbType.Int;
                        Resultado.Value = idVenta;
                        comando.Parameters.Add(Resultado);

                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = venta.IdUsuario });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {

                        }
                    }
                    conexion.Close();
                }

        }

        public static void EliminarVenta(int Id)
        {
            GestionBaseDeDatos db = new GestionBaseDeDatos();


            string query = "DELETE FROM Venta WHERE Id=@Id";

            // se usa la conexion que esta asociada a la connectionstring

                using (SqlConnection conexion = new SqlConnection(db.connectionString))
                {
                    conexion.Open();
                    // se usa el comando que esta asociada a la query conectada a la conexion
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        var Resultado = new SqlParameter();
                        Resultado.ParameterName = "Id";
                        Resultado.SqlDbType = SqlDbType.Int;
                        Resultado.Value = Id;
                        comando.Parameters.Add(Resultado);

                        using (SqlDataReader dataReader = comando.ExecuteReader())
                        {

                        }

                    }
                    conexion.Close();
                }
           
        }

    }
}
