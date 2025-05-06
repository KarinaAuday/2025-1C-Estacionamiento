using _2025_1C_Estacionamiento.Models;

namespace _2025_1C_Estacionamiento.Data
{
    public class RepoPersonas
    {
        private List<Persona> personas;
        public RepoPersonas()
        {
            personas = new List<Persona>();
            Persona persona1 = new Persona() { Nombre = "Luis", Apellido = "Spinetta", Dni = "22334455", Email = "LSpinetta@gmail.com" };
            Persona persona2 = new Persona() { Nombre = "Charly", Apellido = "Garcia", Dni = "22374455", Email = "Cgarcia@gmail.com" };
            Persona persona3 = new Persona() { Nombre = "Gustavo", Apellido = "Cerati", Dni = "12374455", Email = "Cerati@gmail.com" };
            Persona persona4 = new Persona() { Nombre = "Astor", Apellido = "Piazolla", Dni = "22884455", Email = "¨Piazolla@gmail.com" };
            Persona persona5 = new Persona() { Nombre = "Miguel", Apellido = "Mateos", Dni = "26374455", Email = "¨Mateos@gmail.com" };
            personas.Add(persona1);
            personas.Add(persona2);
            personas.Add(persona3);
            personas.Add(persona4);
            personas.Add(persona5);


        }

        public List<Persona> Personas
        {
           get { return personas; }
           set { personas = value; }
        }

    }
}
