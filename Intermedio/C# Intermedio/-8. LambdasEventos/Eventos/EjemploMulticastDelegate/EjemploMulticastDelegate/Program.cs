using System;
using System.IO;

namespace EjemploMulticastDelegate
{
    delegate void ImprimeMensaje(string mensaje);

    class Program
    {
        static void Main(string[] args)
        {
            // Genera un multicast delegate
            ImprimeMensaje imprime = ImprimeEnConsola;
            imprime += ImprimeEnArchivo;
            imprime += ImprimeEnConsola;

            imprime("Hola mundo multicast delegate");
            Console.ReadKey();
        }

        static void ImprimeEnConsola(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        static void ImprimeEnArchivo(string mensaje)
        {
            File.WriteAllText("mensaje.txt", mensaje);
        }
    }
}
