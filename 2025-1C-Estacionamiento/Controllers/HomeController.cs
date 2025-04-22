using _2025_1C_Estacionamiento.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _2025_1C_Estacionamiento.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Pruebas()
        {

            return View();
        }
        public IActionResult Pruebas2(int num , string nombre , string apellido)
        {
            ViewBag.Numero = nombre;
            ViewBag.Apellido = apellido;
            return View(num);
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
