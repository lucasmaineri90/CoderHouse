using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Preentrega_Maineri

/*ObtenerUsuario
 * ListarUsuario
 * CrearUsuario
 * ModificarUsuario
 * EliminarUsuario*/

{
    public class UsuarioData
    {

        public static List<Usuario> ObtenerUsuario(int Id)
        {

            List<Usuario> lista = new List<Usuario>();

            // se creala conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario WHERE Id=@Id;";


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
                                    var Usuario = new Usuario();

                                    Usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                    Usuario.Nombre = dataReader["Nombre"].ToString();
                                    Usuario.Apellido = dataReader["Apellido"].ToString();
                                    Usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                    Usuario.Contrasenia = dataReader["Contraseña"].ToString();
                                    Usuario.Mail = dataReader["Mail"].ToString();
                                    lista.Add(Usuario);

                                    Console.WriteLine("ID: " + Usuario.Id +
                                        " \nNombre: " + Usuario.Nombre +
                                        "\n Apellido: " + Usuario.Apellido +
                                        "\n NombreUsuario: " + Usuario.NombreUsuario +
                                        "\n Contraseña: " + Usuario.Contrasenia +
                                        "\n Mail: " + Usuario.Mail);
                                }
                            }

                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo obtener el usuario " + ex.Message);
            }
            return lista;

        }

        public static List<Usuario> ListarUsuario()
        {

            List<Usuario> lista1 = new List<Usuario>();

            // se creala conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail from Usuario";

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
                                    var Usuario = new Usuario();
                                    Usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                    Usuario.Nombre = dataReader["Nombre"].ToString();
                                    Usuario.Apellido = dataReader["Apellido"].ToString();
                                    Usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                    Usuario.Contrasenia = dataReader["Contraseña"].ToString();
                                    Usuario.Mail = dataReader["Mail"].ToString();
                                    lista1.Add(Usuario);

                                    Console.WriteLine("ID: " + Usuario.Id +
                                     " \nNombre: " + Usuario.Nombre +
                                     "\n Apellido: " + Usuario.Apellido +
                                     "\n NombreUsuario: " + Usuario.NombreUsuario +
                                     "\n Contraseña: " + Usuario.Contrasenia +
                                     "\n Mail: " + Usuario.Mail);
                                }
                            }

                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo listar los usuarios " + ex.Message);
            }
            return lista1;
        }

        public static void CrearUsuario(Usuario usuario)
        {

            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "SET IDENTITY_INSERT Usuario ON  INSERT INTO Usuario (Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail) " +
                "VALUES (@Id, @Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail);";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = usuario.Id });
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contrasenia });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {

                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo crear el usuario " + ex.Message);
            }

        }

        public static void ModificarUsuario (Usuario usuario)
        {
            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "UPDATE Usuario SET Nombre=@Nombre, Apellido=@Apellido, NombreUsuario=@NombreUsuario, Contraseña=@Contraseña, Mail=@Mail " +
                "WHERE Id=@Id ;";

            try
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexion))

                    {
                        comando.Parameters.Add(new SqlParameter("Id", SqlDbType.BigInt) { Value = usuario.Id });
                        comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                        comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                        comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                        comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contrasenia });
                        comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                        using (SqlDataReader dr = comando.ExecuteReader())
                        {

                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("No se pudo modificar el usuario " + ex.Message);
            }

        }

        public static void EliminarUsuario (int Id)
        {
            // se crea la conexion a la base de datos

            string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

            // se crea la query para seleccionar el prducto


            string query = "DELETE FROM Usuario WHERE Id=@Id";

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
                Console.WriteLine("No se pudo eliminar el usuario " + ex.Message);
            }

        }

    }
}   