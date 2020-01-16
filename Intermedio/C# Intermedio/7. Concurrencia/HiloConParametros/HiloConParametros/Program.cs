using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HiloConParametros
{

    // creo un delegado con la firma necesaria para capturar
    // el valor devuelto por el método Operacion
    public delegate void MyDelegate(int n);

    public class Calculo
    {
        //Operacion con parametros que deseo trabajar en el hilo
        public static int Operacion(int n, int m)
        {
            n = n + m;
            return n;
        }
    }

    //Creacion del objeto "auxiliar" que me ayudara con los argumentos a recibir.
    public class HiloArgumentos
    {
        int n, m;
        MyDelegate callback = null;

        public HiloArgumentos(int n, int m, MyDelegate callback)
        {
            this.n = n;
            this.m = m;
            this.callback = callback;
        }

        //Metodo que le pasare al delegado del Thread.
        public void Operacion()
        {
            int result = Calculo.Operacion(n, m);
            callback?.Invoke(result);
            //if (callback != null)
            //  callback(result);
        }
    }

    public class Ejemplo
    {
        static int result;

        public static void Main()
        {
            HiloArgumentos hpm = new HiloArgumentos(1000, 200, new MyDelegate(ResultCallback));

            Thread th = new Thread(new ThreadStart(hpm.Operacion));

            th.Start();
            th.Join();

            Console.WriteLine("Resultado de operacion en main: " + result);
            //Por todo lo echo anteriormente es mas recomendable el uso de los Task, pues nos facilitan la utilizacion del codigo.
            Console.ReadKey();
        }

        //Metodo al que le pasaremos el resultado final
        public static void ResultCallback(int n)
        {
            result = n;
            Console.WriteLine("Resultado de la operación: " + n);
        }
    }
}
