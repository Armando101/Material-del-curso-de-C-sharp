using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catchem
{
    class Pokemon
    {
        public string nombre;
        public string ataque = "Salpicadura";

        public Pokemon(string nombre) {
            this.nombre = nombre;
        }

        public Pokemon(string nombre, string ataque) : this(nombre) {
            this.ataque = ataque;
        }

        public void atacar() {
            Console.WriteLine(nombre + " ataca con " + ataque);
        }
    }
}
