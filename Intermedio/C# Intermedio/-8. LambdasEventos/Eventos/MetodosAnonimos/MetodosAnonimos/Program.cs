using System;
using System.IO;

namespace MetodosAnonimos
{
    delegate void ImprimeMensaje(string mensaje);

    /// <summary>
    /// Métodos anónimos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ImprimeMensaje imprime = delegate(string mensaje)
            {
                Console.WriteLine(mensaje);
            };

            imprime += delegate(string mensaje)
            {
                File.WriteAllText("mensaje.txt", mensaje);
            };

            RegistraMensaje(imprime, "Hola mundo multicast delegate con métodos anónimos");
        }

        static void RegistraMensaje(ImprimeMensaje imprime, string mensaje)
        {
            // Invoca a los métodos registrados en el delgado
            imprime(mensaje);
        }
    }
}
