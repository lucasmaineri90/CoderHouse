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
    public class ProductoVendidoData

    {

        public static List<ProductoVendido> ObtenerProductoVendido(int IdProducto)
        {

            List<ProductoVendido> lista = new List<ProductoVendido>();

            // se creala conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "SELECT Id, Stock, IdProducto, IdVenta from dbo.ProductoVendido WHERE IdProducto=@IdProducto;";


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
                                    var ProductoVendido = new ProductoVendido();
                                    ProductoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                                    ProductoVendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                    ProductoVendido.IdProducto = Convert.ToInt32(dataReader["IdProducto"]);
                                    ProductoVendido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);
                                    lista.Add(ProductoVendido);

                                    Console.WriteLine("ID: " + ProductoVendido.Id +
                                        " \nStock: " + ProductoVendido.Stock +
                                        "\n IdProducto: " + ProductoVendido.IdProducto +
                                        "\n IdVenta: " + ProductoVendido.IdVenta);
                                }
                            }

                        }
                    }
                    conexion.Close();
                }
            }catch (Exception ex)
            {
                Console.WriteLine("No se pudo obtener el producto vendido " + ex.Message);

            }
            return lista;

        }

        public static List<ProductoVendido> ListarProductoVendido()
        {

            List<ProductoVendido> lista1 = new List<ProductoVendido>();

            // se creala conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "SELECT Id, Stock, IdProducto, IdVenta from dbo.ProductoVendido";
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
                                    var ProductoVendido = new ProductoVendido();
                                    ProductoVendido.Id = Convert.ToInt32(dataReader["Id"]);
                                    ProductoVendido.Stock = Convert.ToInt32(dataReader["Stock"]);
                                    ProductoVendido.IdProducto = Convert.ToInt32(dataReader["IdProducto"]);
                                    ProductoVendido.IdVenta = Convert.ToInt32(dataReader["IdVenta"]);
                                    lista1.Add(ProductoVendido);

                                    Console.WriteLine("ID: " + ProductoVendido.Id +
                                        " \nStock: " + ProductoVendido.Stock +
                                        "\n IdProducto: " + ProductoVendido.IdProducto +
                                        "\n IdVenta: " + ProductoVendido.IdVenta);
                                }
                            }

                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo listar los productos vendidos " + ex.Message);
            }
            return lista1;
        }

        public static void CrearProductoVendido(ProductoVendido productovendido)
        {

            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = " SET IDENTITY_INSERT ProductoVendido ON INSERT INTO productoVendido (Id, Stock, IdProducto, IdVenta) " +
                "VALUES (@Id, @Stock, @IdProducto, @IdVenta) ;";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = productovendido.Id });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productovendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.BigInt) { Value = productovendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.BigInt) { Value = productovendido.IdVenta });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {

                        }
                    }
                    conexion.Close();
                }
            }catch(Exception ex)
            {
                Console.WriteLine("No se pudo crear el producto vendido " + ex.Message);
            }

        }

        public static void ModificarProductoVendido(ProductoVendido productovendido)
        {
            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "UPDATE productovendido SET Id=@Id ,Stock=@Stock, IdVenta=@IdVenta " +
                "WHERE IdProducto=@IdProducto ;";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = productovendido.Id });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = productovendido.Stock });
                        comando.Parameters.Add(new SqlParameter("IdProducto", SqlDbType.Int) { Value = productovendido.IdProducto });
                        comando.Parameters.Add(new SqlParameter("IdVenta", SqlDbType.Int) { Value = productovendido.IdVenta });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {

                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo modificar el producto vendido " + ex.Message);
            }

        }

        public static void EliminarProductoVendido(int IdProductoVendido)
        {
            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "DELETE FROM productovendido WHERE IdProducto=@IdProducto";

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
                        Resultado.ParameterName = "IdProducto";
                        Resultado.SqlDbType = SqlDbType.Int;
                        Resultado.Value = IdProductoVendido;
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
                Console.WriteLine("No se pudo eliminar el producto vendido " + ex.Message);
            }

        }

    }
}
