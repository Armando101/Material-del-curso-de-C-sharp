using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokéDexListas
{
    class Program
    {
        static void Main(string[] args)
        {


            string Nombre, Tipo;
            int entrada;
            string del;
            Pokémon pokemon;
            //bool delpoke;

            List <Pokémon> LSPokéDex = new List<Pokémon>();

            LSPokéDex.Add(new Pokémon(Nombre = "Bulbasaur", Tipo = "Hierba"));
            LSPokéDex.Add(new Pokémon(Nombre = "Squirtle", Tipo = "Agua"));
            LSPokéDex.Add(new Pokémon(Nombre = "Charmander", Tipo = "Fuego"));

            Console.WriteLine("PokéDex");
            Console.WriteLine("\nBienvenido!!\n");

            try
            {


                do
                {

                    Console.WriteLine("Menú de la Pokédex:");
                    Console.WriteLine("Eliga una de las siguientes opciones introduciendo su respectivo número:");
                    Console.WriteLine("\n 1 = Agregar Pokémon\n 2 = Borrar Pokémon\n 3 = Consultar Pokédex\n 4 = Salir");

                    entrada = Convert.ToInt16(Console.ReadLine());

                    switch (entrada)
                    {
                        case 1:

                            Console.WriteLine("\n>> Agregar Pokémon:\n");

                            Console.Write("Por favor, escriba el nombre del pokémon: ");
                            Nombre = Console.ReadLine();

                            Console.Write("\nPor favor, escriba el tipo del pokémon: ");
                            Tipo = Console.ReadLine();

                            pokemon = new Pokémon(Nombre, Tipo);

                            LSPokéDex.Add(pokemon);

                            Console.WriteLine("\n -> Lista de pokémon actualmente en el programa PokéDex:");

                            foreach (Pokémon poke in LSPokéDex)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" " + poke.Nombre + " " + poke.Tipo);
                            }

                            break;

                        case 2:

                            Console.WriteLine("\n>> Eliminar Pokémon:\n");

                            Console.Write("¿Qué Pokémon desea eliminar?: ");
                            del = Console.ReadLine();

                            var delpoke = LSPokéDex.Single(poke => poke.Nombre == del);

                            LSPokéDex.Remove(delpoke);

                            Console.WriteLine("\n -> Lista de pokémon actualmente en el programa PokéDex:");

                            foreach (Pokémon poke in LSPokéDex)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" " + poke.Nombre + " " + poke.Tipo);
                            }

                            break;

                        case 3:

                            Console.WriteLine("\n>> Consultar PokéDex:");

                            Console.WriteLine("\n -> Lista de pokémon actualmente en el programa PokéDex:");

                            foreach (Pokémon poke in LSPokéDex)
                            {
                                Console.WriteLine();
                                Console.WriteLine(" " + poke.Nombre + " " + poke.Tipo);
                            }

                            break;

                        case 4:

                            Console.WriteLine("\nFinalizando programa PokéDex...");

                            break;

                        default:

                            Console.WriteLine("\nEl dato introducido no corresponde a ninguna de las opciones");

                            break;


                    }

                    Console.WriteLine();

                }

                while (entrada != 4);
            }


            catch (NullData ND)
            {
                Console.WriteLine("Error. La entrada de datos está vacía\n");
                Console.WriteLine("\n" + ND.Message);
            }

            catch (InvalidOperationException IOE)
            {
                Console.WriteLine("Error. No se puede realizar la operación\n");
                Console.WriteLine("\n" + IOE.Message);
            }

            finally
            {
                Console.WriteLine("Programa PokéDex Finalizado\n");
            }



            Console.WriteLine("Oprime Enter...");
            Console.ReadKey(true);

        }
    }
}
