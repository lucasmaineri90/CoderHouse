using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionUI.SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet(Name = "ListarProducto")]
        public IEnumerable<Producto> productos()
        {
            return ProductoBussiness.ListarProducto().ToArray();
        }
        [HttpGet("{Id}")]

        public IActionResult ObtenerProducto(int Id)
        {
            Producto producto = ProductoBussiness.ObtenerProducto(Id);
            return Ok(producto);
        }

        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] int id)
        {
            ProductoBussiness.EliminarProducto(id);
        }

        [HttpPut(Name = "ModificarProducto")]

        //public void Put([FromBody] Usuario usuario)
        //{
        //    UsuarioBussiness.ModificarUsuario(usuario);

        //}

        [HttpPost(Name = "AltaProducto")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.CrearProducto(producto);
        }
    }
}
