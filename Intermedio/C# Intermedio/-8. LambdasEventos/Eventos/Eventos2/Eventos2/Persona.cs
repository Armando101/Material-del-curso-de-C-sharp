using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eventos2
{
    class Persona
    {
        public string Nombre { get; set; }

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

        public void OnCambioDeLuz(object sender, SemaforoEventArgs e)
        {
            if (e.Color == "verde")
            {
                Console.WriteLine(Nombre + " se detiene en la banqueta.");
            }
            else
            {
                Console.WriteLine(Nombre + " cruza la calle.");
            }
        }
    }
}
