using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    // Declara un delegado que recibe un double y devuelve un double
    delegate double Operacion(double numero);

    /// <summary>
    /// Delegados
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {                    
            // Sintaxis para crear un objeto de tipo delegate
            //Operacion op = new Operacion(Cuadrado);

            // Sintaxis abreviada para crear un objeto delegate
            Operacion op = Cuadrado;
            double num = 5;
            // Ejecuta al método target del delegado
            double resultado = op(num);
            Console.WriteLine("{0} * {0} = {1}", num, resultado);

            op = Cubo; // cambia el target del delegado
            resultado = op(num);
            Console.WriteLine("{0} * {0} * {0} = {1}", num, resultado);
        }

        static double Cuadrado(double numero)
        {
            return numero * numero;
        }

        static double Cubo(double numero)
        {
            return Math.Pow(numero, 3);
        }


    }
}
