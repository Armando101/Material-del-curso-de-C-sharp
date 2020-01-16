using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokéDexListas
{
    class Pokémon
    {
        private string nombre;
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;

                if (string.IsNullOrEmpty(nombre))
                {
                    throw new NullData();
                }

            }
        }


        public string Tipo { get; set; }

        public Pokémon(string nombre)
        {
            Nombre = nombre;
        }

        public Pokémon(string nombre, string tipo) : this(nombre)
        {
            Tipo = tipo;
        }

        public override string ToString()
        {
            return string.Format("Pokémon: {0} \nTipo: {1}", Nombre, Tipo);
        }
    }
}
