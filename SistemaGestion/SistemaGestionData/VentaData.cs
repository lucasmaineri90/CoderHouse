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

        private static string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";
        public static Venta ObtenerVenta(int Id)
        {

            string query = "SELECT Id, Comentarios, IdUsuario FROM Venta WHERE Id=@Id;";


            using (SqlConnection conexion = new SqlConnection(connectionString))
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

            string query = "SELECT Id, Comentarios, IdUsuario from Venta";

            using (SqlConnection conexion = new SqlConnection(connectionString))
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

        public static bool CrearVenta(Venta venta)
        {


            string query = "INSERT INTO Venta (Comentarios, IdUsuario) " +
                "VALUES (@Comentarios, @IdUsuario);";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = venta.Id });
                        comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.BigInt) { Value = venta.IdUsuario });

                       return comando.ExecuteNonQuery() > 0;
                    }
                }

        }

        public static bool ModificarVenta(int idVenta, Venta venta)
        {

            string query = "UPDATE Venta SET Comentarios=@Comentarios, IdUsuario=@IdUsuario" +
                " WHERE Id=@Id";

                using (SqlConnection conexion = new SqlConnection(connectionString))
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

                        return comando.ExecuteNonQuery() > 0;
                    }
                   
                }

        }

        public static bool EliminarVenta(int Id)
        {


            string query = "DELETE FROM Venta WHERE Id=@Id";

            // se usa la conexion que esta asociada a la connectionstring

                using (SqlConnection conexion = new SqlConnection(connectionString))
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

                        return comando.ExecuteNonQuery() > 0;

                    }
                    
                }
           
        }

    }
}
