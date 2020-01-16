using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBasico
{
    class Program
    {
        /*
         * Programa que obtenga la calificación final de los alumnos del curso de C#
         * para ello el usuario ingresará lo siguiente:
         * - Nombre del alumno a calificar 
         * - Apellidos del alumno 
         * - Calificación de su proyecto
         * - Cantidad de tareas entregadas (1-5, 5=40% así como 1=8%)
         * - Cantidad de participaciones
         * 
         * El programa guardará en un arreglo de objetos los datos de los alumnos 
         * (para ello creará una clase llamda Alumno).
         * 
         * Por medio de una clase estática llamada Calculadora hará el cálculo de la calificación de todos los alumnos.
         * 
         * El flujo del programa es el siguiente:
         * 1.- Pedir el número de alumnos
         * 2.- Ingresar los datos de todos los alumnos
         * 3.- Mostrar al usuario las calificaciones de todos los alumnos
         */
        static void Main(string[] args)
        {
            string nombre, aP, aM;
            double califP;
            int tareas, participaciones;


            Console.WriteLine("Ingresa el número de alumnos a calificar: ");
            int cantidad = Convert.ToInt16(Console.ReadLine());
            
            Alumno[] lista = new Alumno[cantidad];

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("\n\nDatos del alumno" + (i+1) + ":");
                Console.WriteLine("Nombre:");
                nombre = Console.ReadLine();
                Console.WriteLine("Apellido Paterno:");
                aP = Console.ReadLine();
                Console.WriteLine("Apellido Materno:");
                aM = Console.ReadLine();
                Console.WriteLine("Calificación del proyecto:");
                califP = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Cantidad de tareas:");
                tareas = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Cantidad de participaciones:");
                participaciones = Convert.ToInt16(Console.ReadLine());

                lista[i] = new Alumno(nombre, aP, aM,califP,tareas,participaciones);

            }

            for (int i = 0; i < cantidad; i++)
            {
                Calculadora.califica(lista[i]);
            }

        }
    }
}
