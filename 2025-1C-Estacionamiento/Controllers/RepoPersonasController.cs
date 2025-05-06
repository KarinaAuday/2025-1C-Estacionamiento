using _2025_1C_Estacionamiento.Data;
using _2025_1C_Estacionamiento.Models;
using Microsoft.AspNetCore.Mvc;

namespace _2025_1C_Estacionamiento.Controllers
{
    public class RepoPersonasController : Controller
    {
        private readonly EstacionamientoContext _context;//Atributo privado de la clase, contexto de la base de datos

        public RepoPersonasController (EstacionamientoContext contexto)
        {
            _context = contexto; //Inicializa el contexto de la base de datos
                
        }


        public IActionResult Index()
        {
            return View();
        }


       public IActionResult CreatePost()
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

            _context.Add(persona); //Agrega la persona al contexto
            _context.SaveChanges(); //Guarda los cambios en la base de datos

            return View(persona);
        }

        public IActionResult RepoPersonas()
        {
            var personas = new RepoPersonas();

            foreach (Persona persona in personas.Personas)
            {
                if (!_context.Personas.Any(p => p.Dni == persona.Dni)) //Verifica si la persona ya existe en la base de datos
                {
                    _context.Add(persona); //Agrega la persona al contexto
                }
               
            }
            _context.SaveChanges();
            return View (_context.Personas.ToList()); //Devuelve la lista de personas desde el contexto de la base de datos
        }

    }
}
