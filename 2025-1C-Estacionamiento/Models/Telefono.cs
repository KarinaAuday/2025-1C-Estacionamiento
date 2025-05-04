using _2025_1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _2025_1C_Estacionamiento.Models
{
    public class Telefono
    {

        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsge.Required)]
        [RegularExpression(@"\d{3,5}", ErrorMessage = "El código de área debe tener entre 3 y 5 dígitos.")]
        public int CodArea { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Numero { get; set; }

        public bool Principal { get; set; }


        public TipoTelefono Tipo { get; set; }


        //Propiedad RELACIONAL
        [Required(ErrorMessage = ErrorMsge.Required)]
        public int PersonaId { get; set; }

        //Propiedad navegacional
        public Persona Persona { get; set; }

        //public Cliente Cliente { get; set; }

        [NotMapped]  //No lo toma en la base de datos
        public string NumeroCompleto { get { return $"({CodArea}) - {Numero}"; } }
    }
}
