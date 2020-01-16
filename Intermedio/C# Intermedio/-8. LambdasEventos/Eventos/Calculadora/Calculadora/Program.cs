using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        delegate int Operacion(int num1, int num2);

        static void Main(string[] args)
        {
            string comando = Console.ReadLine(); // 1+2+3+4+5
            char[] operadores = comando.ToArray();
            Operacion op = null;
            int acumulador = (int)Char.GetNumericValue(operadores[0]); //1

            int num1=0, num2=0;

            for (int i = 0; i < operadores.Length - 2; i += 2)
            {
                num1 = acumulador;
                num2 = (int)Char.GetNumericValue(operadores[i + 2]); //2
                char operador = operadores[i + 1]; // +

                switch (operador)
                {
                    case '+': op += Suma; break;
                    case '-': op += Resta; break;
                    case '*': op += Multiplicacion; break;
                    case '/': op += Division; break;
                    default: op += null; break;
                }

                //if (op != null)
                //{
                    acumulador = op(num1, num2);
                //    Console.WriteLine(acumulador);
                //}
            }

            Console.WriteLine(op(num1,num2));
        }

        static int Division(int num1, int num2)
        {
            return num1 / num2;
        }

        static int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        static int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
