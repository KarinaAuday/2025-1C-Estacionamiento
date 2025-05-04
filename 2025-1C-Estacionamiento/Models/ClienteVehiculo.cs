using _2025_1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Eventing.Reader;

namespace _2025_1C_Estacionamiento.Models
{
    public class ClienteVehiculo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsge.Required)]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = ErrorMsge.Required)]

        public int VehiculoId { get; set; }

        public Cliente Cliente { get; set; }

        public Vehiculo Vehiculo { get; set; }



        public bool ResponsablePrincipal { get; set; }

        public ClienteVehiculo() { }
    }
}
