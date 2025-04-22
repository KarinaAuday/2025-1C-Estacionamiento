namespace _2025_1C_Estacionamiento.Models
{
    public class Telefono
    {

        public int Id { get; set; }
        public string Tipo { get; set; }

        public string Prefijo { get; set; }
        public string Numero { get; set; }

        public int PersonaId { get; set; } //Esto es una propiedad RELACIONAL

        Persona Persona { get; set; } //Esto es una propiedad de NAVEGACIONAL
    }
}
