namespace _2025_1C_Estacionamiento.Models
{
    public class Direccion
    {

        public int Id { get; set; }

        public string Calle { get; set; }

        public int Altura { get; set; }
        public int CodigoPostal { get; set; }

        public string Localidad { get; set; }

        public string Provincia { get; set; }

        public int PersonaId { get; set; } //Esto es una propiedad RELACIONAL

        public Persona Persona { get; set; } //Esto es una propiedad de NAVEGACIONAL
    }
}
