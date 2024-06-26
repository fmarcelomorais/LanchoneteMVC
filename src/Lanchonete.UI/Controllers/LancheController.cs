using Lanchonete.Application.Interfaces;
using Lanchonete.UI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lanchonete.UI.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheService _lancheService;
        public LancheController(ILancheService lancheService)
        {
            _lancheService = lancheService;
        }
        public async Task<IActionResult> Lanches()
        {
            ViewData["Titulo-Lista"] = "Todos os Lanches";
   
            var lanchesECategoria = new ListaLanches();
            lanchesECategoria.Lanches = await _lancheService.RetornaLanches();
            lanchesECategoria.CategoriaAtual = "Categoria";
            

            return View(lanchesECategoria);
        }
    }
}
