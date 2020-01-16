using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasico
{
    static class Calculadora
    {
        static public void califica(Alumno alumno){

            double final = alumno.califP*6 + alumno.tareas*8;
            if (alumno.participaciones>6)
                final+=8;

            Console.WriteLine("La calificación final de {0} {1} {2} es de: {3}/100",
                alumno.nombre,alumno.apellidoP,alumno.apellidoM, final);
        }
    }
}
