using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            clsRegistroPersona regPer = new clsRegistroPersona();
            //Simepre devemos colocar el operado += cuando no se este trabajando sobre la clase padre.
            regPer.evento += MetodoEjecutar;
            regPer.evento += MetodoEjecutar2;
            for (int i = 0; i < 5; i++)
                regPer.AgregarPersona(lista);
            foreach (var p in lista)
            {
                Console.WriteLine(p.Nombre);
            }

            Console.ReadKey();
        }

        static int MetodoEjecutar(int var)
        {
            Console.WriteLine("El numero de personas registradas es: " + var);
            return var;
        }

        static int MetodoEjecutar2(int var)
        {
            Console.WriteLine("Persona {0} agregada!", var);
            return 1;
        }
    }
}
