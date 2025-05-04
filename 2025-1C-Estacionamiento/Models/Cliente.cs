using _2025_1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace _2025_1C_Estacionamiento.Models
{
    public class Cliente : Persona
    {
        public Cliente() { }

        [Required(ErrorMessage = ErrorMsge.Required)]
        [Display(Name = "Numero Cuil")]
        public long Cuil { get; set; }

        //public Direccion Direccion { get; set; }

        public List<ClienteVehiculo> VehiculosAutorizados { get; set; }
    }
}
