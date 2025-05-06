using Microsoft.EntityFrameworkCore;
using _2025_1C_Estacionamiento.Models;

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
