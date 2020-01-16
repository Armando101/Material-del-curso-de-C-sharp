using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoBasico
{
    class Alumno
    {
        public string nombre, apellidoP, apellidoM;
        public double califP;
        public int tareas, participaciones;

        public Alumno(string nombre, string apellidoP, string apellidoM, double califP, int tareas, int participaciones) {
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.califP = califP;
            if (tareas <= 5)
                this.tareas = tareas;
            else
                this.tareas = 5;
            this.participaciones = participaciones;
        }

    }
}
