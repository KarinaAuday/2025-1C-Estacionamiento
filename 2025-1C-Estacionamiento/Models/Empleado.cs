using _2025_1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2025_1C_Estacionamiento.Models
{
    public class Empleado : Persona
    {
        [Required(ErrorMessage = ErrorMsge.Required)]
        public string Nrolegajo { get; set; }

        public Empleado()
        {
                
        }
    }
}
