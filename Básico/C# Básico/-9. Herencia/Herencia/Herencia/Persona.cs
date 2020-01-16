using System;


namespace Herencia
{
   public class Persona
    {
        protected string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona() { }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;    
        }

        public virtual void Saludar() // Virtual indica que se va a sobre-escribir
        {
            Console.WriteLine("Hola, mi nombre es {0}", Nombre);
        }

        public override string ToString()  // Override sobre-escribe
        {
            return string.Format("{0}, {1} años", Nombre, Edad);
        }


    }
}
