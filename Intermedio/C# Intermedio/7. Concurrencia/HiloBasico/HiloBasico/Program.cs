using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HiloBasico
{

    delegate int MyDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Principal";
            Thread hiloHijo = new Thread(new ThreadStart(Contador));
            hiloHijo.Name = "Hijo";
            hiloHijo.Start();
            //hiloHijo.Join();
            Contador();

            //ThreadStart es un delegado que recibe como argumento un metodo sin argumentos y sin tipo de retorno.
            Thread hiloHijo2 = new Thread(suma);
            hiloHijo2.Start(1);

            Console.ReadKey();
        }

        public static void Contador() { 
            for (int i = 0; i < 100; i++)
			{
                Console.WriteLine(Thread.CurrentThread.Name+ " - " + i);
			}
        }

        public static void suma(object obj)
        {
            Console.WriteLine("El elemento pasado es: " + obj.ToString());
        }
    }
}
