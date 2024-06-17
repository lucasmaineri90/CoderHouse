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
    public class ProductoData
    {

        private static string  connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";


        public static Producto ObtenerProducto(int IdProducto)
        {
  

            string query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario from dbo.Producto WHERE Id=@IdProducto;";

            // se usa la conexion que esta asociada a la connectionstring
            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // se usa el comando que esta asociada a la query conectada a la conexion
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var Resultado = new SqlParameter();
                    Resultado.ParameterName = "IdProducto";
                    Resultado.SqlDbType = SqlDbType.Int;
                    Resultado.Value = IdProducto;
                    comando.Parameters.Add(Resultado);

                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {

                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);
                                return producto;

                            }
                        }
                        throw new Exception("Id no fue encontrado");

                    }
                }
                conexion.Close();
            }
        }

        public static List<Producto> ListarProducto()
        {
            List<Producto> lista1 = new List<Producto>();


            string query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario from dbo.Producto;";

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
                                var producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Descripcion = dataReader["Descripciones"].ToString();
                                producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);
                                lista1.Add(producto);

                            }
                        }

                    }
                }
                conexion.Close();
            }
            return lista1;
        }

        public static bool CrearProducto(Producto producto)
        {


            string query = "INSERT INTO producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) " +
                "VALUES (@Descripciones, @Costo, @PrecioVenta, @Stock, @IdUsuario) ;";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripcion });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.IdUsuario });


                        return comando.ExecuteNonQuery() > 0;
                    }
                }
        }


        public static bool ModificarProducto(int IdProducto, Producto producto) 
        {


            string query = "UPDATE producto SET Descripciones=@Descripciones, Costo=@Costo, PrecioVenta=@PrecioVenta, Stock=@Stock, IdUsuario=@IdUsuario " +
                "WHERE Id=@Id ;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))

                {
                    var Resultado = new SqlParameter();
                    Resultado.ParameterName = "IdProducto";
                    Resultado.SqlDbType = SqlDbType.Int;
                    Resultado.Value = IdProducto;
                    comando.Parameters.Add(Resultado);

                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripcion });
                    comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                    comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                    comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.IdUsuario });

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }


        public static bool EliminarProducto(int IdProducto)
        {


            string query = "DELETE FROM producto WHERE Id=@IdProducto";

            // se usa la conexion que esta asociada a la connectionstring
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    // se usa el comando que esta asociada a la query conectada a la conexion
                    using (SqlCommand comando = new SqlCommand(query, conexion))
                    {
                        var Resultado = new SqlParameter();
                        Resultado.ParameterName = "IdProducto";
                        Resultado.SqlDbType = SqlDbType.Int;
                        Resultado.Value = IdProducto;
                        comando.Parameters.Add(Resultado);


                        return comando.ExecuteNonQuery() > 0;

                    }
                }
        }


    }
}

