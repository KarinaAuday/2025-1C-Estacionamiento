using Microsoft.AspNetCore.Mvc;
using _2025_1C_Estacionamiento.Models;
using _2025_1C_Estacionamiento.Data;

namespace _2025_1C_Estacionamiento.Controllers
{
    public class PersonasRepoController : Controller
    {
        private readonly EstacionamientoContext _contexto; //Atributo privado de la clase. Contexto de base de datos
        public PersonasRepoController(EstacionamientoContext contexto)
        {
            _contexto = contexto;
        }
        //Creo un DB context. Fuerzo a recibir un contexto de base de datos


        public IActionResult Index()
        {
            return View();
        }

        public ActionResult CreateGet()   //Ejemplo Con Get
        {

            return View();

        }
        //Creo Persona con Post
        public ActionResult CreatePost() //Ejemplo con Post
        {

            return View();

        }
        //Creo persona con query string
        public IActionResult CrearPersona(string nombre, string apellido, string dni, string email)
        {

            Persona persona = new Persona()

            {
                Apellido = apellido,
                Dni = dni,
                Nombre = nombre,
                Email = email
            };
            _contexto.Add(persona); //Agrego la persona al contexto
            _contexto.SaveChanges();

            return View(persona);

        }

        public IActionResult RepoPersonas()
        {
            //  creo las Personas que traigo de la DB y la hago tolist

            //List<Persona> Personas = _contexto.Personas.ToList();

            var personas = new RepoPersonas();

            //lista de personas

            foreach (Persona persona in personas.Personas)
            {
                if (!_contexto.Personas.Any(p => p.Dni == persona.Dni))
                {
                    _contexto.Personas.Add(persona);
                }
            }
            _contexto.SaveChanges(); // fuera del foreach

            return View(_contexto.Personas.ToList());
        }
    }
}
