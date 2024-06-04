using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Preentrega_Maineri
{
    public class VentaData
    {

        public static List<Venta> ObtenerVenta(int Id)
        {

            List<Venta> lista = new List<Venta>();

            // se creala conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "SELECT Id, Comentarios, IdUsuario FROM Venta WHERE Id=@Id;";


            // se usa la conexion que esta asociada a la connectionstring
            try
            {
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

                                    lista.Add(Venta);

                                    Console.WriteLine("ID: " + Venta.Id +
                                        " \nComentario: " + Venta.Comentarios +
                                        "\nIdUsuario: " + Venta.IdUsuario);
                                }
                            }

                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo obtener la venta " + ex.Message);
            }
            return lista;

        }

        public static List<Venta> ListarVenta()
        {

            List<Venta> lista1 = new List<Venta>();

            // se creala conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "SELECT Id, Comentarios, IdUsuario from Venta";

            try
            {
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

                                    Console.WriteLine("ID: " + Venta.Id +
                                        " \nComentario: " + Venta.Comentarios +
                                        "\n IdUsuario: " + Venta.IdUsuario);
                                }
                            }

                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo listar las ventas " + ex.Message);
            }
            return lista1;
        }

        public static void CrearVenta(Venta venta)
        {

            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "SET IDENTITY_INSERT Venta ON  INSERT INTO Venta (Id, Comentarios, IdUsuario) " +
                "VALUES (@Id, @Comentarios, @IdUsuario);";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
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
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo crear la venta " + ex.Message);
            }

        }

        public static void ModificarVenta(Venta venta)
        {
            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "UPDATE Venta SET Comentarios=@Comentarios, IdUsuario=@IdUsuario" +
                " WHERE Id=@Id";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
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
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo modificar la venta " + ex.Message);
            }

        }

        public static void EliminarVenta(int Id)
        {
            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "DELETE FROM Venta WHERE Id=@Id";

            // se usa la conexion que esta asociada a la connectionstring
            try
            {
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

                        }

                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo listar los productos vendidos " + ex.Message);
            }
        }


    }
}

