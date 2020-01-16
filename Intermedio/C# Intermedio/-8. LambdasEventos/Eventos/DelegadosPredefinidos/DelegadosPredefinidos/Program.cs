using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosPredefinidos
{
    /// <summary>
    /// Delegados predefinidos en .NET
    /// Action<T>, Func<T>, Predicate<T>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Action: Delegado, recibe parametros, no entrega nada (void)
            Action<string> mostrar = s => Console.WriteLine(s);
            mostrar("Usando Action<>");

            Action<int, int> suma = (x, y) => Console.WriteLine("{0}+{1} = {2}", x, y, x + y);
            suma(15, 2);

            //Func: Delegado, recibe parametros, entrega parametros
            Func<int, int> cubo = n => n * n * n;
            int num = 5;
            Console.WriteLine("Cubo de {0} es {1}",num, cubo(num));

            Func<string, string, string> saludo = (nombre, apellido) => "Hola " + nombre + apellido;
            Console.WriteLine(saludo("Juan","Fonseca"));

            //Predicate: Delegado, recibe UN parametro, entrega bool
            Predicate<int> positivo = n => n >= 0;
            Console.WriteLine("{0} es positivo?: {1}",num,positivo(num));

            Predicate<string> empiezaConE = s => s.StartsWith("E");
            Console.WriteLine("{0} empieza con E?: {1}","Hola",empiezaConE("Hola"));
            
        }
    }
}
