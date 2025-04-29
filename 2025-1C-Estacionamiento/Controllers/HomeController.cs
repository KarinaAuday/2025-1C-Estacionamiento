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
          //  if (!String.IsNullOrEmpty(mensajeError))
            //{
              //     ViewBag.MensajeError = mensajeError;
           // }

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

        public IActionResult Pruebas3()
        {
            List<string> ciudades = new List<string> { "Buenos Aires", "Paris", "Madrid", "Rio de Janeiro" };
            return View(ciudades);
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

        //Ejmplo de Uso de ViewBag , ViewData y TempData
        public IActionResult PasoParametros(int id, string nombreProducto, string descripcion, double precio)
        {
            // accedo asi
            //Home/PasoParametros/?id=1&nombreProducto=iphone&descripcion=caro&precio=1000
            //Chekeo que recibi los parametros
            if (id > 0 && !String.IsNullOrEmpty(nombreProducto) && !String.IsNullOrEmpty(descripcion))
            {
                //Uso ViewBag
                ViewBag.Id = id;
                ViewBag.nombreProducto = nombreProducto;
                //Uso ViewData
                ViewData["descripcion"] = descripcion;
                //Uso TempData
                TempData["Precio"] = precio;
                return View();
            }
            else
            {
                //Paso parametros con El New
                TempData["Error"] = "Error en el producto a mostrar";
                return RedirectToAction("Index", "Home");
            }
        }

    }
}
