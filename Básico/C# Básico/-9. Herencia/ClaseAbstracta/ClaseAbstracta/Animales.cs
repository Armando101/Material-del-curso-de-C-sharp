using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Lobo : Carnivoro
    {
        public Lobo(string nombre) 
            : base (nombre) { 

        }

        public void MuestraColmillos() {
            Console.WriteLine("El lobo muestra sus colmillos!");
        }

        public override void Caza() {
            Console.WriteLine("El " + NombreComun +  " usa sus colmillos para cazar");
        }

    }

    class Pinguino : Carnivoro
    {
        public Pinguino(string nombre)
            : base(nombre)
        {

        }

        public void DaSaltitos()
        {
            Console.WriteLine("El pingüino da saltitos!");
        }

        public void Caza()
        {
            Console.WriteLine("El " + NombreComun + " usa su pico para cazar");
        }

    }
}
