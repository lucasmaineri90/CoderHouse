using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionUI.SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "ListarVenta")]
        public IEnumerable<Venta> Ventas()
        {
            return VentaBussiness.ListarVenta().ToArray();
        }
        [HttpGet("{Id}")]

        public IActionResult ObtenerVenta(int Id)
        {
            Venta Ventas = VentaBussiness.ObtenerVenta(Id);
            return Ok(Ventas);
        }

        [HttpDelete(Name = "EliminarVenta")]
        public void Delete([FromBody] int id)
        {
            VentaBussiness.EliminarVenta(id);
        }

        [HttpPut(Name = "ModificarVenta")]

        //public void Put([FromBody] Usuario usuario)
        //{
        //    UsuarioBussiness.ModificarUsuario(usuario);

        //}

        [HttpPost(Name = "AltaVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.CrearVenta(venta);
        }
    }
}
