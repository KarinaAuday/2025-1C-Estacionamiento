namespace _2025_1C_Estacionamiento;
using _2025_1C_Estacionamiento.Data;
using Microsoft.EntityFrameworkCore;

public class Program
{
    //Esto es una prueba
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        // Configurar el contexto de base de datos en memoria
        builder.Services.AddDbContext<EstacionamientoContext>(options =>
           options.UseInMemoryDatabase("EstacionamientoDb"));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
