using _2025_1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2025_1C_Estacionamiento.Models
{
    public class Direccion
    {

        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsge.Required)]
        public string Calle { get; set; }
        [Required(ErrorMessage = ErrorMsge.Required)]
        public int Altura { get; set; }
        public int CodigoPostal { get; set; }

        [Required(ErrorMessage = ErrorMsge.Required)]

        public string Localidad { get; set; }

        [Required(ErrorMessage = ErrorMsge.Required)]
        public string Provincia { get; set; }

        public int PersonaId { get; set; } //Esto es una propiedad RELACIONAL

        public Persona Persona { get; set; } //Esto es una propiedad de NAVEGACIONAL
    }
}
