using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using CrudAPI.Data;
using CrudAPI.Models;


namespace CrudAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoData _productoData;

        public ProductoController(ProductoData productoData)
        {
            _productoData = productoData;

        }
        [HttpGet()]
        public async Task<IActionResult> Lista()
        { 
            List<Producto> Lista =  await _productoData.Lista();
            return StatusCode(StatusCodes.Status200OK, Lista);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Obtener(int id)
        {
            Producto objeto = await _productoData.Obtener(id);
            return StatusCode(StatusCodes.Status200OK, objeto);
        }

        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Producto objeto)
        {
            bool respuesta = await _productoData.Crear(objeto);
            return StatusCode(StatusCodes.Status200OK, new { isSuccess = respuesta });
        }

    }
}
