using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SuspendResume
{
    class Program
    {
        static Thread hijo = null;
        static Thread hija = null;
        static void Main(string[] args)
        {
            hijo = new Thread(new ThreadStart(Numeros));
            hijo.Name = "Hijo";
            hija = new Thread(new ThreadStart(Letras));
            hija.Name = "HiloHija";
            hijo.Start();
            hija.Start();
        }

        static public void Numeros() {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " - " + i);
                if (i==5)
                {
                    Thread.CurrentThread.Suspend();
                }
            }
        }

        static public void Letras() {
            for (char i = 'a'; i < 'z'; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " - " + i);
            }
            hijo.Resume();
        }
    }
}
