﻿namespace ComparacionDeObjetos
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Persona(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        //Sobreescribimos el metodo Equals que por defecto compara dir de memoria.
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Persona p = obj as Persona;
            if (p == null)
            {
                return false;
            }

            return (Nombre == p.Nombre) && (Edad == p.Edad);
        }

        // Opcionalmente podemos añadir Equals(Persona)
        // y hacer override de GetHashCode
        public bool Equals(Persona p)
        {
            if (p == null)
            {
                return false;
            }

            return (Nombre == p.Nombre) && (Edad == p.Edad);
        }

        //GetHashCode es un algoritmo que te regresara un numero definido en un 
        //algoritmo definido por ti.
        public override int GetHashCode()
        {
            int hash = 17;
            hash = (hash * 7) + Nombre.GetHashCode();
            hash = (hash * 7) + Edad.GetHashCode();

            return hash;
        }
    }
}
