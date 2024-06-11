using SistemaGestionUI.SistemaGestionData;
using SistemaGestionUI.SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public static List<Usuario> ListarUsuarios()
        {
            return UsuarioData.ListarUsuario();


        }
        public static Usuario ObtenerUsuario(int id)
        {
            return UsuarioData.ObtenerUsuario(id);

        }

        public static void CrearUsuario(Usuario usuario)
        {
            UsuarioData.CrearUsuario(usuario);
        }

        public static void ModificarUsuario (int id, Usuario usuario)
        {
            UsuarioData.ModificarUsuario(id, usuario);

        }

        public static void EliminarUsuario(int id)
        {
            UsuarioData.EliminarUsuario(id);
        }


      
    }
}
