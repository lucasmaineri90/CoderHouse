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
    public class ProductoVendidoData
    {

        private static string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";
        public static ProductoVendido ObtenerProductoVendido(int IdProducto)
        {


            string query = "SELECT Id, Stock, IdProducto, IdVenta from dbo.ProductoVendido WHERE Id=@Id;";


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
                    Resultado.Value = IdProducto;
                    comando.Parameters.Add(Resultado);

                    using (SqlDataReader dataReader = comando.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var ProductoVendido = new ProductoVendido();
                                ProductoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                                ProductoVendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                ProductoVendido.IdProducto = Convert.ToInt32(dataReader["IdProducto"]);
                                ProductoVendido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);

                                return ProductoVendido;
                            }
                        }

                    }
                    throw new Exception("Id no fue encontrado");
                }
                conexion.Close();
            }

        }

        public static List<ProductoVendido> ListarProductoVendido()
        {

            List<ProductoVendido> lista1 = new List<ProductoVendido>();



            string query = "SELECT Id, Stock, IdProducto, IdVenta from dbo.ProductoVendido";

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
                                var ProductoVendido = new ProductoVendido();
                                ProductoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                                ProductoVendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                ProductoVendido.IdProducto = Convert.ToInt32(dataReader["IdProducto"]);
                                ProductoVendido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);
                                lista1.Add(ProductoVendido);

                            }
                        }

                    }
                }
                conexion.Close();
            }
            return lista1;
        }

        public static bool CrearProductoVendido(ProductoVendido productovendido)
        {


            string query = "INSERT INTO productoVendido (Stock, IdProducto, IdVenta) " +
                "VALUES (@Stock, @IdProducto, @IdVenta) ;";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = productovendido.Id });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productovendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = productovendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = productovendido.IdVenta });

                        return comando.ExecuteNonQuery() > 0;
                    }
                }

        }

        public static bool ModificarProductoVendido(int Id, ProductoVendido productovendido)
        {


            string query = "UPDATE productovendido SET Stock=@Stock, IdVenta=@IdVenta, IdProducto=@IdProducto " +
                "WHERE Id=@Id ;";

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        var Resultado = new SqlParameter();
                        Resultado.ParameterName = "Id";
                        Resultado.SqlDbType = SqlDbType.Int;
                        Resultado.Value = Id;
                        comando.Parameters.Add(Resultado);


                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productovendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productovendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productovendido.IdVenta });

                        return comando.ExecuteNonQuery() > 0;

                    }
                    conexion.Close();
                }

        }

        public static bool EliminarProductoVendido(int IdProductoVendido)
        {

            string query = "DELETE FROM productovendido WHERE IdProducto=@IdProducto";

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
                        Resultado.Value = IdProductoVendido;
                        comando.Parameters.Add(Resultado);

                        return comando.ExecuteNonQuery() > 0;

                    }
                } 

        }
    }
}

