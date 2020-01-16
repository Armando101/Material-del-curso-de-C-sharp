using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catchem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Pokemon pokemon1 = new Pokemon("Charmander","lanza llamas");
            Pokemon pokemon2 = new Pokemon("Magikarp");
            Pokeball bola = new Pokeball("Masterball",pokemon2);
            Pokeball bolavacia = new Pokeball();
            Entrenador trainer = new Entrenador("Vadik", bola);

            Console.WriteLine(pokemon1.nombre + " salvaje aparece!");
            trainer.SacaPokemon();
            pokemon1.atacar();
            pokemon2.atacar();
            bolavacia.SacarPokemon(); ;
            bolavacia.Atrapar(pokemon1);
        }
    }
}
