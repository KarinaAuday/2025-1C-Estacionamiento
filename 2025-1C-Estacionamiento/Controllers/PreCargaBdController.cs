using _2025_1C_Estacionamiento.Data;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using _2025_1C_Estacionamiento.Models;
using System;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net;

namespace _2025_1C_Estacionamiento.Controllers
{

    public class PreCargaBdController : Controller
    {
        private readonly EstacionamientoContext _context;

        public PreCargaBdController(EstacionamientoContext context)
        {
            _context = context;
        }


        #region Lista de Clientes
        private List<Cliente> clientes = new List<Cliente>
        {
            new Cliente { Id = 1, Nombre = "Juan", Apellido = "Pérez", Dni = "12345678" , Email ="charly@ort.edu.ar" , Cuil=2222222 },
            new Cliente { Id = 2, Nombre = "Ana", Apellido = "Gómez", Dni = "87654321" ,Email ="Pepe@ort.edu.ar" , Cuil=2299922 },
            new Cliente { Id = 3, Nombre = "Luis", Apellido = "Martínez", Dni = "11223344" , Email ="Alber@ort.edu.ar" , Cuil=6666666}
        };


        #endregion Creacion Clientes
        #region Lista de Vehiculos
        private List<Vehiculo> vehiculos = new List<Vehiculo>()
        {
            new Vehiculo(2034444,"Ford taunus" , "Verde"),
            new Vehiculo(8484848, "Renault Clio" , "Azul") ,
            new Vehiculo(5647866, "Mercedes benz" , "amarillo"),
        };
        #endregion
        #region Creacion de Personas con Direccion asociada
        private void InicializoPersonas()
        {
            Persona persona1 = new Persona()
            {
                Nombre = "Juan Carlos",
                Apellido = "Baglietto",
                Dni = "97528788",
                Email = "Baglieto@gmail.com",
            };
            _context.Add(persona1);
            _context.SaveChanges();
            Direccion direccion1 = new Direccion()
            {
                Calle = "Calle Falsa",
                Altura = 123,
                Localidad = "Ciudad Ficticia",
                Provincia = "Provincia Imaginaria",
                PersonaId = persona1.Id
            };
            _context.Add(direccion1);
            _context.SaveChanges();
        }
        #endregion


        #region Inicializo BD

        public IActionResult InicializarBD()
        {
            crearClientes();
            crearVechiculos();
            InicializoPersonas();
            //Mando como parametro un mensage para mostrar en la vista con ViewBag
            TempData["PrecargaOK"] = "PreCarga de Base de Datos finalizada";
            return RedirectToAction("Index", "Home");
        }



        #endregion

        private void crearClientes()
        {
            foreach (var cliente in clientes)
            {
                if (!_context.Clientes.Any(c => c.Dni == cliente.Dni))
                {
                    _context.Clientes.Add(cliente);
                    _context.SaveChanges();
                }
            }
        }

        private void crearVechiculos()
        {
            foreach (var vehiculo in vehiculos)
            {
                if (!_context.Vehiculo.Any(p => p.Patente == vehiculo.Patente))
                {
                    _context.Vehiculo.Add(vehiculo);
                    _context.SaveChanges();
                }
            }
        }
    }
}
