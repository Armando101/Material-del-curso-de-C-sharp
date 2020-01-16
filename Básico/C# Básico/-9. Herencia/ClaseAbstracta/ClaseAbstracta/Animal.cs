using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    // Una clase abstracta no se puede instanciar (no se puede invocar al contructor)
    abstract class Animal
    {
        // A pesar de que no podemos instanciar, animal será heredado
        // por lo tanto tenemos un constructor para pasarle su nombre 
        public Animal(string s) {
            NombreComun = s;
        }

        // Variable y propiedad para manejo del nombre del animal
        private string nombre;
        
        public string NombreComun { 
            get {
                return nombre;
            }
            set { nombre = value; 
            }
        }

        // Propiedad abstracta, es de solo lectura, 
        // necesitamos herencia para que sea útil
        public abstract string Come
        {
            get;
        }

        public override string ToString()
        {
            return nombre + " " + Come;
        }

    }
}
