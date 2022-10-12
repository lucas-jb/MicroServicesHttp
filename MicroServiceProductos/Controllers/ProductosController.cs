using MicroServiceProductos.DAL;
using Microsoft.AspNetCore.Mvc;

namespace MicroServiceProductos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductosProvider _productosRepository;

        public ProductosController(IProductosProvider productosRepository)
        {
            _productosRepository = productosRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync(string id)
        {
            var result = await _productosRepository.GetAsync(id);

            if (result != null)
            {
                return Ok(result);
            }

            return NotFound();
        }
    }
}
