using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos2
{
    // 1. Declarar el delegado
    // 2. Crear tipo de dato event para ligarlo al delegado
    // 3. (En Persona) Declarar metodo Suscribe para asignarlo al delegado

    // Clase envoltura que encapsula las propiedades que queremos pasar
    // como parámetros del evento
    public class SemaforoEventArgs : EventArgs
    {
        public string Color { get; set; }
    }

    class Semaforo
    {
        //// Declaracion del delegado
        public delegate void CambioDeLuzEventHandler(object sender, SemaforoEventArgs e);
        // Estructura del evento
        //public CambioDeLuzEventHandler CambioDeLuz = Prueba;
        //public event CambioDeLuzEventHandler CambioDeLuz;

        //EventHandler (Controlador de eventos) es el evento que define un delegado que
        //tiene como arguemtnos un object(Objeto que lanza el evento) y la clase que sera
        //a la que modificaremos cuando se lanze la exepcion.
        public EventHandler<SemaforoEventArgs> CambioDeLuz; // Equivalente a las lineas anteriores

        public string Color { get; set; }

        // Método para levantar el evento
        // Comportamiento interno
        public void CambiarLuz()
        {
            if (Color == "rojo") Color = "verde";
            else Color = "rojo";
            Console.WriteLine("\nCambió la luz a " + Color);

            // Después de terminar el comportamiento interno, se llama al delegado
            OnCambioDeLuz();
        }

        // Método para ejecutar acciones cuando el evento suceda
        // Comportamiento externo
        public void OnCambioDeLuz()
        {
            if(CambioDeLuz!=null)
            {
                // Creación de objeto SemaforoEventArgs
                // a partir del valor de la propiedad Color 
                // dentro de Semáforo
                CambioDeLuz(this, new SemaforoEventArgs() { Color = this.Color });
            }
        }

        public static void Prueba(object sender, SemaforoEventArgs e)
        {
            Console.WriteLine("Esta es una prueba.");
        }
    }
}






