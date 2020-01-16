using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Semaforo s = new Semaforo() { Color = "rojo" };
            Auto auto = new Auto();
            Persona persona1 = new Persona() { Nombre = "Marco" };
            Persona persona2 = new Persona() { Nombre = "Javi" };
            
            s.CambiarLuz(); // Nadie está atento al evento
               
            auto.Subscribe(s);
            persona1.Subscribe(s);
            s.CambiarLuz();
            persona2.Subscribe(s);
            s.CambiarLuz();
            persona1.Unsubscribe(s);
            s.CambiarLuz();

            auto.Unsubscribe(s); // Quitamos la suscripción al evento
            s.CambiarLuz();

            Console.ReadKey();
        }
    }
}
