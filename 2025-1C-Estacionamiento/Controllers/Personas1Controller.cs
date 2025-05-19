using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _2025_1C_Estacionamiento.Data;
using _2025_1C_Estacionamiento.Models;

namespace _2025_1C_Estacionamiento.Controllers
{
    public class Personas1Controller : Controller
    {
        private readonly EstacionamientoContext _context;

        public Personas1Controller(EstacionamientoContext context)
        {
            _context = context;
        }


        //Buscador 
        public ActionResult Buscar(string ?cli)
        {
            if (!String.IsNullOrEmpty(cli))
            {
                // Realiza la lógica de búsqueda utilizando el término "q".
                var resultados = _context.Personas.Where(c => c.Apellido.Contains(cli)).ToList();

                // Devuelve la vista de resultados con la lista de resultados.
                return View("Buscador", resultados);
            }
            else
            {
                return View("Buscador");
            }
       

            
           
        }
        // GET: Personas1
        public IActionResult Index()
        {
            return View(_context.Personas.ToList());
        }

        // GET: Personas1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // GET: Personas1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Personas1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Nombre,Apellido,Dni,Email,Profesion")] Persona persona)
        {
            if (ModelState.IsValid)
            {
                _context.Add(persona);
                _context.SaveChanges();
                // return RedirectToAction(nameof(Index));
                //Creo direccion para la persona
                return RedirectToAction("Create", "Direccions", new { id = persona.Id });
            }
            return View(persona);
        }

        // GET: Personas1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas.FindAsync(id);
            if (persona == null)
            {
                return NotFound();
            }
            return View(persona);
        }

        // POST: Personas1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Apellido,Dni,Email,Profesion")] Persona persona)
        {
            if (id != persona.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persona);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonaExists(persona.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(persona);
        }

        // GET: Personas1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persona = await _context.Personas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (persona == null)
            {
                return NotFound();
            }

            return View(persona);
        }

        // POST: Personas1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persona = await _context.Personas.FindAsync(id);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonaExists(int id)
        {
            return _context.Personas.Any(e => e.Id == id);
        }
    }
}
