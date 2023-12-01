using System.Threading.Tasks;
using Application.Services.Categoria;
using Microsoft.AspNetCore.Mvc;

namespace SIMPRESS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            _categoriaService = categoriaService ?? throw new ArgumentNullException(nameof(categoriaService));
        }

        // GET: api/categoria
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categorias = await _categoriaService.ObterTodosCategorias();
            return Ok(categorias);
        }
    }
}
