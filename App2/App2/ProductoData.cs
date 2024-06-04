using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Preentrega_Maineri
{
    // se crea la clase
    public class ProductoData
    {
        public static List<Producto> ObtenerProducto(int IdProducto)
        {

            List<Producto> lista = new List<Producto>();

            // se creala conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario from dbo.Producto WHERE Id=@IdProducto;";

            try {
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
                                    producto.IdUsuario = dataReader["IdUsuario"].ToString();
                                    lista.Add(producto);

                                    Console.WriteLine("ID: " + producto.Id +
                                        " \nDescripcion: " + producto.Descripcion +
                                        "\n Costo: " + producto.Costo +
                                        "\n Precio Venta: " + producto.PrecioVenta +
                                        "\n Stock: " + producto.Stock +
                                        "\n IdUsuario: " + producto.IdUsuario);
                                }
                            }

                        }
                    }
                    conexion.Close();
                }     
            } catch (Exception ex)
            {
                Console.WriteLine("No se pudo obtener el producto: " + ex.Message);
            }
            return lista;
        }

        public static List<Producto> ListarProducto() {

            List<Producto> lista1 = new List<Producto>();

            // se creala conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario from dbo.Producto;";

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
                                    var producto = new Producto();
                                    producto.Id = Convert.ToInt32(dataReader["Id"]);
                                    producto.Descripcion = dataReader["Descripciones"].ToString();
                                    producto.Costo = Convert.ToDouble(dataReader["Costo"]);
                                    producto.PrecioVenta = Convert.ToDouble(dataReader["PrecioVenta"]);
                                    producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                    producto.IdUsuario = dataReader["IdUsuario"].ToString();
                                    lista1.Add(producto);

                                    Console.WriteLine("ID: " + producto.Id +
                                        " \nDescripcion: " + producto.Descripcion +
                                        "\n Costo: " + producto.Costo +
                                        "\n Precio Venta: " + producto.PrecioVenta +
                                        "\n Stock: " + producto.Stock +
                                        "\n IdUsuario: " + producto.IdUsuario);
                                }
                            }

                        }
                    }
                    conexion.Close();
                }
            }catch (Exception ex)
            {
                Console.WriteLine("No se pudo listar los producto " + ex.Message);
            }
            return lista1;
        }

        public static void CrearProducto(Producto producto)
        {

            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "INSERT INTO producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario) " +
                "VALUES (@Descripciones, @Costo, @PrecioVenta, @Stock, @IdUsuario) ;";

            try
            {
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

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {

                        }
                    }
                    conexion.Close();
                }
            }catch (Exception ex)
            { 
                Console.WriteLine("No se pudo crear el producto " + ex.Message);
            }               
        }
       

        public static void ModificarProducto(Producto producto) {
            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "UPDATE producto SET Descripciones=@Descripciones, Costo=@Costo, PrecioVenta=@PrecioVenta, Stock=@Stock, IdUsuario=@IdUsuario " +
                "WHERE Id=@Id ;";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                        comando.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripcion });
                        comando.Parameters.Add(new SqlParameter("Costo", SqlDbType.Money) { Value = producto.Costo });
                        comando.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Money) { Value = producto.PrecioVenta });
                        comando.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                        comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.VarChar) { Value = producto.IdUsuario });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {

                        }
                    }
                    conexion.Close();
                }
            } catch (Exception ex)
            {
                Console.WriteLine("No se pudo modificar el producto " + ex.Message);
            }
        }


        public static void EliminarProducto(int IdProducto)
        {
            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "DELETE FROM producto WHERE Id=@IdProducto";

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

                        }

                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo eliminar el producto " + ex.Message);
            }


        }
    }
  
}


