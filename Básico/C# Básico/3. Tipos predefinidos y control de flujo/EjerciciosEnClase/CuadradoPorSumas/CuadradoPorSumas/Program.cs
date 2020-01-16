using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuadradoPorSumas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hacer cuadrado de:");
            int valor = Int32.Parse(Console.ReadLine());
            Console.WriteLine(CuadradoImpar(valor));
        }

        static int CuadradoImpar(int valor)
        {
            int suma = 0;
            for (int i = 1, impar = 1; i <= valor; i++, impar += 2)
            {
                suma += impar;
            }
            return suma;
        }
    }
}
