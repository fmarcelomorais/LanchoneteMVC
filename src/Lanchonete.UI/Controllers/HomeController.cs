using Lanchonete.Application.Interfaces;
using Lanchonete.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lanchonete.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoriaService _categoriaService;
        public HomeController(ICategoriaService service) { _categoriaService = service;  }
        public IActionResult Index()
        {
            var categoria = _categoriaService.RetornaCategorias();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
