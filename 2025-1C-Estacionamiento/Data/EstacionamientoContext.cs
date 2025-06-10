using Microsoft.EntityFrameworkCore;
using _2025_1C_Estacionamiento.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Emit;

namespace _2025_1C_Estacionamiento.Data
{
    public class EstacionamientoContext : IdentityDbContext<IdentityUser<int>, IdentityRole<int>, int>
    {
        public EstacionamientoContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Direccion> Direccion { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }

        public DbSet<Telefono> Telefono { get; set; }

        public DbSet<Rol> Rol { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            ////Modifico la Entidad Identity User para que guarde en Las tablas que yo quiero
            builder.Entity<IdentityUser<int>>().ToTable("Personas");
            builder.Entity<IdentityRole<int>>().ToTable("Roles");
            //Relacion usuario-Roles
            builder.Entity<IdentityUserRole<int>>().ToTable("UsuarioRoles");

            builder.Entity<Vehiculo>().HasIndex(v => v.Patente).IsUnique(); //Patente unica
        }


    }
}
