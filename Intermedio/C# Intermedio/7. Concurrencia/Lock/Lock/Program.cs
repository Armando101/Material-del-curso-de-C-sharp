using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Lock
{
    class Program
    {
        // Internal es para que solo lo vea el proyecto
        internal static Thread[] hilos = new Thread[10];
        static void Main(string[] args)
        {
            Cuenta ac = new Cuenta(0);

            for (int i = 0; i < 10; i++)
            {
                Thread t = new Thread(new ThreadStart(ac.Realizar_Transacciones));
                hilos[i] = t;
                hilos[i].Name = "Hilo - " + i;
            }

            for (int i = 0; i < 10; i++)
            {
                hilos[i].Start();
            }
            Console.ReadKey();
        }
    }

    class Cuenta 
    {
        public int Saldo { get; set; }

        Random num = new Random();

        public Cuenta(int saldo_inicial) {
            Saldo = saldo_inicial;
        }

        public int Realiza_Transaccion(int cantidad) {
            lock(this){
                Console.WriteLine("Vamos mover "+ cantidad+ "pesos.");
                if ((Saldo + cantidad) >0) { 
                    Thread.Sleep(5);
                    Saldo += cantidad;
                    Console.WriteLine(Thread.CurrentThread.Name + " -- Saldo: " + Saldo);
                    return Saldo;
                }
                else {
                    Console.WriteLine(Thread.CurrentThread.Name + "  Acción imposible, el saldo sería: " + (Saldo + cantidad));
                    return 0;
                }
            }
        }

        public void Realizar_Transacciones() {
            for (int i = 0; i < 5; i++)
            {
                Realiza_Transaccion(num.Next(-500, 100));
            }
        }

    }

}
