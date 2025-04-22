using System.Diagnostics.Eventing.Reader;

namespace _2025_1C_Estacionamiento.Models
{
    public class PersonaVehiculo
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }//Esto es una propiedad RELACIONAL
        public int VehiculoId { get; set; }//Esto es una propiedad RELACIONAL

        public Persona Persona { get; set; } //Esto es una propiedad de NAVEGACIONAL

        public Vehiculo Vehiculo { get; set; } //Esto es una propiedad de NAVEGACIONAL
        public bool EstaAutorizado { get; set; } 

        public PersonaVehiculo()
        {
                
        }
    }
}
