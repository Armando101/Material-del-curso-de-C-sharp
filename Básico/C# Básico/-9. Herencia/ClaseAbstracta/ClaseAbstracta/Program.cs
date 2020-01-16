using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animales ={
                            new Carnivoro("León"),
                            new Hebivoro("Jirafa")
            };

            Console.WriteLine("Lista de animales:");

            foreach (Animal anima in animales)
            {
                Console.WriteLine(anima);
            }

            Lobo lobo = new Lobo("Lobo gris");
            lobo.Caza();
            (lobo as Carnivoro).Caza();

            Pinguino pingu = new Pinguino("Pingüino emperador");
            pingu.Caza();
            (pingu as Carnivoro).Caza();

            //Array.Resize(ref animales, animales.Length + 2);

            //foreach (Animal anima in animales)
            //{
            //    Console.WriteLine(anima);
            //}

        }
    }
}
