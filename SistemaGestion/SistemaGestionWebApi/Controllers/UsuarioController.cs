using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionUI.SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "ListarUsuario")]
        public IEnumerable<Usuario> usuario()
        {
            return UsuarioBussiness.ListarUsuarios().ToArray();
        }
        [HttpGet("{Id}")]

        public IActionResult ObtenerUsuario(int Id)
        {
            Usuario usuario = UsuarioBussiness.ObtenerUsuario(Id);
            return Ok(usuario);
        }

        [HttpDelete(Name = "EliminarUsuario")]
        public void Delete([FromBody] int id)
        {
            UsuarioBussiness.EliminarUsuario(id);
        }

        [HttpPut(Name = "ModificarUsuario")]

        //public void Put([FromBody] Usuario usuario)
        //{
        //    UsuarioBussiness.ModificarUsuario(usuario);

        //}

        [HttpPost(Name = "AltaUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBussiness.CrearUsuario(usuario);
        }
    }
}
