using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EjercicioClase
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int renglones, columnas;
            Console.WriteLine("Ingresa el numero de renglones: ");
            renglones = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el numero de columnas: ");
            columnas = Convert.ToInt32(Console.ReadLine());

            Matriz m = new Matriz(renglones,columnas);
            //Thread hilo1 = new Thread(m.SumaMatriz);
            //Thread hilo2 = new Thread(m.SumaMatriz);

            //hilo1.Name = "Hilo 1";
            //hilo2.Name = "Hilo 2";

            //DateTime t1 = DateTime.Now;
            //hilo1.Start();
            //hilo2.Start();

            //Console.WriteLine("Tiempo transcurrido Total: " + (DateTime.Now - t1));

            //t1 = DateTime.Now;
            m.SumaMatriz();
            Console.WriteLine("Tiempo transcurrido Total un solo hilo: " + (DateTime.Now - t1));

            Console.WriteLine("---------------");
            Console.WriteLine("Matriz resultante: ");
            for (int i = 0; i < renglones; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(m.c[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }

    internal class Matriz
    {
        Random num = new Random();
        //sinternal int[,] a = new int[2,2];
        //internal int[,] b = new int[2,2];
        //internal int[,] c = new int[2,2];

        internal int[,] a, b, c;
        int renglones, columnas;

        public Matriz(int renglones,int columnas)
        {
            this.renglones = renglones;
            this.columnas = columnas;
            a = new int[renglones, columnas];
            b = new int[renglones, columnas];
            c = new int[renglones, columnas];
            for (int i = 0; i < renglones; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    a[i,j] = num.Next(-100, 100);
                    b[i,j] = num.Next(-100, 100);
                }
            }
        }

        public int SumaMatriz()
        {
            int var = 0;
            for (int i = 0; i < renglones; i++)
                for (int j = 0; j < columnas; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    var += a[i, j] + b[i, j];
                }
        }

        public async void Suma()
        {
            var
        }
    }
}
