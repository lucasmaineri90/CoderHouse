using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionUI.SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet(Name = "ListarProductoVendido")]
        public IEnumerable<ProductoVendido> productosVend()
        {
            return ProductoVendidoBussiness.ListarProductoVendido().ToArray();
        }
        [HttpGet("{Id}")]

        public IActionResult ObtenerProducto(int Id)
        {
            ProductoVendido productoVend = ProductoVendidoBussiness.ObtenerProductoVendido(Id);
            return Ok(productoVend);
        }


        [HttpDelete(Name = "EliminarProductoVendido")]
        public void Delete([FromBody] int id)
        {
            ProductoVendidoBussiness.EliminarProductoVendido(id);
        }

        [HttpPut(Name = "ModificarProductoVendido")]

        //public void Put([FromBody] Usuario usuario)
        //{
        //    UsuarioBussiness.ModificarUsuario(usuario);

        //}

        [HttpPost(Name = "AltaProductoVendido")]
        public void Post([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.CrearProductoVendido(productoVendido);
        }

    }
}
