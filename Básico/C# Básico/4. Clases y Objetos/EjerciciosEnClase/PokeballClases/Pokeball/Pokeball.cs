using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catchem
{
    class Pokeball
    {
        string tipo;
        public Pokemon pokemon = null;
        bool usada;

        public Pokeball() {
            tipo = "Pokeball";
            usada = false;
        }

        public Pokeball(string tipo)
        {
            this.tipo = tipo;
            usada = false;
        }

        public Pokeball(string tipo,Pokemon p)
        {
            this.tipo = tipo;
            usada = true;
            pokemon = p;
        }

        public void Atrapar(Pokemon poke) {
            if (usada)
                Console.WriteLine(tipo + " usada, no puedes usarla para atrapar otro Pokémon.");
            else
                Console.WriteLine("Has atrapado un " + poke.nombre); 
        }

        public void SacarPokemon() {
            if (usada)
                Console.WriteLine(pokemon.nombre + " yo te elijo!!");
            else
                Console.WriteLine("Tu " + tipo + " está vacía! :(");
        }

        public void MostrarDatos() {
            if (pokemon==null)
                Console.WriteLine("Tu " + tipo + " está vacía.");
            else
            {
                Console.WriteLine(tipo + " con un " + pokemon.nombre + " que sabe usar " + pokemon.ataque);
            }
        }
    }
}
