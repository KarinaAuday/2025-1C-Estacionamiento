using Microsoft.AspNetCore.Mvc;
using _2025_1C_Estacionamiento.Models;

namespace _2025_1C_Estacionamiento.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CrearPersona(string nombre, string apellido, string dni, string email)
        {
            Persona persona = new Persona()
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                Email = email
            };
       
            return View(persona);
        }


        public IActionResult CrearGet()
        {
            return View();
        }

        public IActionResult CrearPost()
        {
            return View();
        }
    }
}
