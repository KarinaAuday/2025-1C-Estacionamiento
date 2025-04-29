using System.ComponentModel.DataAnnotations;
using _2025_1C_Estacionamiento.Helpers;
namespace _2025_1C_Estacionamiento.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required (ErrorMessage = ErrorMsge.Required)]
        [Display(Name = "Nombresito")]
        [StringLength(50, ErrorMessage = ErrorMsge.StringLength)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = ErrorMsge.SoloLetras)]
        public string Nombre { get; set; }

        [Required (ErrorMessage = ErrorMsge.Required)]
        public string Apellido { get; set; }

        [Required (ErrorMessage = "El DNI es requerido")]
        public string Dni { get; set; }

        [Required (ErrorMessage = "El email es requerido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public List<Telefono> Telefonos { get; set; } //Lista de telefonos es propiedad navegacional NO lleva required

        public Direccion Direccion { get; set; }
        public Persona()
        {
                
        }
    }
}
