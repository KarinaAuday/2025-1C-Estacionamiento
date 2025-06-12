using _2025_1C_Estacionamiento.Helpers;
using System.ComponentModel.DataAnnotations;

namespace _2025_1C_Estacionamiento.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = ErrorMsge.Required)]
        [Display(Name = "Correo Electrónico")]
        [EmailAddress(ErrorMessage = ErrorMsge.NoValido)]
        public string Email { get; set; }

        [Required(ErrorMessage = ErrorMsge.Required)]
        [DataType(DataType.Password)]
        [Display(Name = Alias.Password)]
        public string Password { get; set; }


    }
}
