using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposDeReferencia
{
    /// <summary>
    /// Tipos de referencia
    /// Los tipos de referencia también son conocidos como objetos    
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //int a = null;

            // Objeto
            object ob = null; //new object();

            if (ob == null)
            {
                Console.WriteLine("Objeto haciendo referencia a null");
            }
            else
            {
                Console.WriteLine("Objeto no nulo {0}",ob.ToString());
            }

            // Cadena
            string cadena = "Esta es una cadena";

            // Referencia especial null
            // Solo los tipos de referencia pueden ser asignados a null
            string cadenaNula = null;
            object objetoNulo = null;

            // Referencia a un tipo dinamico
            dynamic din;
        }
    }
}
