using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                esperaTarea();
                string resultadoLectura = Console.ReadLine();
                Console.WriteLine("La entrada fue: " + resultadoLectura);
            }
        }

        //Inidica que el metodo debe ser sincronizado con otros metodos mas.
        //Inidica al compilador que el metodo sera asincrono (realizas las invocacion, pero continuas la ejecucion).
        static async void esperaTarea()
        {
            //Await: Inidica al compilador que no espere a que termine la ejecucion para continuar.
            //El await va de la mano con Task.Run, juntos indican que el subproceso creado sera asincronico.
            string resultadoSuma = await Task.Run(
              //(): No recibe argumentos => tareaARealizar
                () => tareaEnSegundoPlano(new Random().Next(10000, 100000))
                );
            Console.WriteLine("Resultado de tarea en segundo plano: " + resultadoSuma);
        }

        static string tareaEnSegundoPlano(int numero)
        {
            Console.WriteLine("Numero entrante: " + numero);
            int suma = 0;
            for (int i = 1; i < numero; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    suma += j;
                }
            }
            return suma.ToString();
        }
    }
}











