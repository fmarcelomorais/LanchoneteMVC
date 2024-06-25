using Lanchonete.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete.UI.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoriaService _categoriaService;
        public CategoriaController(ICategoriaService service) { _categoriaService = service; }
        public async Task<IActionResult> Categorias()
        {
            var categorias = await _categoriaService.RetornaCategorias();
            return View(categorias);
        }
    }
}
