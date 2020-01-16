using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Catchem
{
    class Entrenador
    {
        string nombre;
        Pokeball ball;

        public Entrenador(string nombre, Pokeball bola) {
            this.nombre = nombre;
            ball = bola;
        }

        public void SacaPokemon() {
            ball.SacarPokemon();
            Console.WriteLine(nombre + " sacó a " + ball.pokemon.nombre);
        }
    }
}
