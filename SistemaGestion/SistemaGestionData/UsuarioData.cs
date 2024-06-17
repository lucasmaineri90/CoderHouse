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
    public class UsuarioData
    {
        private static string connectionString = @"Server=. ; Database =C#; Trusted_Connection=True;";

        public static Usuario ObtenerUsuario(int Id)
        {


            string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario WHERE Id=@Id;";

            // se usa la conexion que esta asociada a la connectionstring

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                // se usa el comando que esta asociada a la query conectada a la conexion
                SqlCommand comando = new SqlCommand(query, conexion);

                var Resultado = new SqlParameter();
                Resultado.ParameterName = "Id";
                Resultado.SqlDbType = SqlDbType.Int;
                Resultado.Value = Id;
                comando.Parameters.Add(Resultado);

                SqlDataReader dataReader = comando.ExecuteReader();

                if (dataReader.Read())
                {

                    var Usuario = new Usuario();

                    Usuario.Id = Convert.ToInt32(dataReader["Id"]);
                    Usuario.Nombre = dataReader["Nombre"].ToString();
                    Usuario.Apellido = dataReader["Apellido"].ToString();
                    Usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                    Usuario.Contraseña = dataReader["Contraseña"].ToString();
                    Usuario.Mail = dataReader["Mail"].ToString();

                    return Usuario;
                }
                throw new Exception("Id no fue encontrado");
                conexion.Close();
            }

        }

        public static List<Usuario>  ListarUsuario()
        {
            List<Usuario> lista1 = new List<Usuario>();


            string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail from Usuario";

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
                                Usuario Usuario = new Usuario();
                                Usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                Usuario.Nombre = dataReader["Nombre"].ToString();
                                Usuario.Apellido = dataReader["Apellido"].ToString();
                                Usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                Usuario.Contraseña = dataReader["Contraseña"].ToString();
                                Usuario.Mail = dataReader["Mail"].ToString();
                                lista1.Add(Usuario);

                            }
                        }

                    }
                }
                conexion.Close();
            }
            return lista1;
        }

        public  static bool CrearUsuario(Usuario usuario)
        {


            string query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) " +
                "VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail);";

            SqlConnection conexion = new SqlConnection(connectionString);

            
            using (SqlCommand comando = new SqlCommand(query, conexion))
            {
                comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                conexion.Open();

                return comando.ExecuteNonQuery() > 0;
            }
        }


        public  static bool ModificarUsuario(int Id, Usuario usuario)
        {


            string query = "UPDATE Usuario SET Nombre=@Nombre, Apellido=@Apellido, NombreUsuario=@NombreUsuario, Contraseña=@Contraseña, Mail=@Mail " +
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

                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                    comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });

                    return comando.ExecuteNonQuery() > 0;
                }
             
            }
        }


        public  static bool EliminarUsuario(int Id)
        {

            string query = "DELETE FROM Usuario WHERE Id=@Id";

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

