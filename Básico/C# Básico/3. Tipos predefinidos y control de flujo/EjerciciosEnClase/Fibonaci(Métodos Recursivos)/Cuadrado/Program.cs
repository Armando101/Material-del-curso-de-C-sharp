using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertar valor de fibonacci:");
            int valor = Int32.Parse(Console.ReadLine());
            int res2 = fibo(valor);
            Console.WriteLine("Resultado es :" + res2);
            res2 = fiborec(valor);
            Console.WriteLine("Resultado es :"+res2);
            Console.ReadKey();
            
        }
        
        static int fibo(int valor)
        {
            int resultado=1;
            if (valor != 0 && valor != 1)
             {
                int n1 = 1, n2 = 1;
                resultado = 0;
                for (int i = 2; i <= valor; i++)
                {
                    resultado = n1 + n2;
                    n1 = n2;
                    n2 = resultado;
                }
            }
            return resultado;
        }

        static int fiborec(int valor)
        {
            if (valor == 0 || valor == 1)
                return 1;
            else
                return fiborec(valor - 1) + fiborec(valor - 2);


        }
    }
}
