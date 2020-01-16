using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseAbstracta
{
    class Carnivoro : Animal
    {
        public Carnivoro(string nombre) : base(nombre) { 
        }

        // Vamos a modificar la propiedad Come,
        // pues un carnívoro no come lo mismo que un herbívoro
        public override string Come
        {
            get { return "Come otros animales"; }
        }

        public virtual void Caza() {
            Console.WriteLine("El animal está cazado!");
        }
    }

    class Hebivoro : Animal
    {
        public Hebivoro(string nombre) : base(nombre) { 
        }

        public override string Come
        {
            get { return "Come plantas"; }
        }

        public void Recolecta() {
            Console.WriteLine("El animal está recolectando comida!");
        }
    }
}
