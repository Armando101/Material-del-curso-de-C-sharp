using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    internal delegate int MyDelegate(string s);

    class clsRegistroPersona
    {
        int i = 1;

        //public event MyDelegate evento2;
        //    <tipo argumento, tipo devuelto>
        public event Func<int, int> evento;

        public void AgregarPersona(List<Persona> lista)
        {
            Persona p = new Persona();
            Console.WriteLine("Ingresa la edad de la nueva persona: ");
            p.Edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre de la nueva persona: ");
            p.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa el id de la nueva persona: ");
            p.ID = Convert.ToInt32(Console.ReadLine());
            evento(i);
            i++;
        }
    }
}
