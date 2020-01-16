using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    /// <summary>
    /// Herencia
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("Carlos", 38);
            p.Saludar();
            Console.WriteLine(p.ToString());

            Empleado e = new Empleado("María", 29, "DBA", 10000);
            e.Saludar();
            e.Trabajar();
            Console.WriteLine(e.ToString());

            // Para explicar is-a usaremos un arreglo de Personas
            Persona p1 = new Persona("Erik", 32);
            Persona p2 = new Persona("Luis", 43);

            Persona[] gente = new Persona[4];
            gente[0] = p;
            gente[1] = p1;
            gente[2] = p2;
            gente[3] = e;

            Console.WriteLine();
            Console.WriteLine("Lista de personas que son empleados");
            foreach (var per in gente)
            {
                if (per is Empleado)
                {
                    Console.WriteLine(per.ToString());
                }
            }

            Console.ReadKey();

        }
    }
}
