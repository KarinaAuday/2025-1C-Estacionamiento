﻿
using _2025_1C_Estacionamiento.Models;
using Microsoft.EntityFrameworkCore;
namespace _2025_1C_Estacionamiento.Data
{
    public class EstacionamientoContext : DbContext
    {

        public EstacionamientoContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Persona> Personas { get; set; }
    }
}
