using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos2
{
    class Auto
    {
        // Método para suscribir el auto al evento
        public void Subscribe(Semaforo s)
        {
            s.CambioDeLuz += OnCambioDeLuz;
        }

        // Método para quitar la suscripción del auto al evento
        public void Unsubscribe(Semaforo s)
        {
            s.CambioDeLuz -= OnCambioDeLuz;
        }

        // Método que se ejecuta cuando sucede el evento
        public void OnCambioDeLuz(object sender, SemaforoEventArgs e)
        {
            if (e.Color == "verde")
            {
                Console.WriteLine("El auto cruza la calle");
            }
            else
            {
                Console.WriteLine("El auto se detuvo");
            }
        }
    }
}
