using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExpresionesLambda
{

    public class TestClass
    {
        //Metodos para el multicast
        internal static void Doble(int val)
        {
            Console.WriteLine("Ejecutando el double: " + (val * 2));
        }
        internal void Triple(int val)
        {
            Console.WriteLine("Ejecutando el triple: " + (val * 3));
        }

        //Metodos para combinar
        internal static int Hello(string s)
        {
            Console.WriteLine("Hello, {0}!", s);
            return 1;
        }
        internal static int GoodBye(string s)
        {
            Console.WriteLine("GoodBye, {0}!", s);
            return 1;
        }
    }
    delegate void MyDelegate(int i);

    delegate int MyDelegate2(string a);

    delegate void ImprimeMensaje(string mensaje);

    delegate void ImprimeMensaje2(string mensaje, string ext);
    /// <summary>
    /// Expresiones Lambda
    /// </summary>
    class Program
    {
        private static void Main(string[] args)
        {

            //Multicast: los metodos se ejecutaran de acuerdo a su orden de entrada, el primero en entrar, sera el primero en salir
            TestClass tc = new TestClass();
            MyDelegate d1;
            d1 = TestClass.Doble;
            Console.WriteLine("--------");
            d1(3);
            d1 += tc.Triple;
            Console.WriteLine("--------");
            d1(2);
            d1 += TestClass.Doble;
            Console.WriteLine("--------");
            d1(4);


            Console.WriteLine();


            //Combinando delegados
            MyDelegate2 a, b, c, d;
            //Instanciando delegados
            a = new MyDelegate2(TestClass.Hello);
            b = new MyDelegate2(TestClass.GoodBye);
            c = a + b;
            d = c - a;
            Console.WriteLine("Delegado a: ");
            Console.WriteLine(a("A"));
            Console.WriteLine();
            Console.WriteLine("Delegado b: ");
            Console.WriteLine(b("B"));
            Console.WriteLine();
            Console.WriteLine("Delegado c: ");
            Console.WriteLine(c("C"));
            Console.WriteLine();
            Console.WriteLine("Delegado d: ");
            Console.WriteLine(d("D"));
            Console.WriteLine();
            Console.WriteLine("Operando los return de mis delegados: " + (a("A")+b("B")));
            Console.WriteLine();

            //Delegados predefinidos
            //Action <Tipo de dato del argumento>
            Action<int> MyActionDelegate = TestClass.Doble;
            MyActionDelegate(1);
            //Func <Tipo de dato del argumento, tipo de dato devuelto>
            Func<string, int> MyFuncDelegate = TestClass.Hello;

        //Definicion de exp lambda haciendo uso de un delegado: nombreDelegado = Parametro => funcion{};
        ImprimeMensaje imprime = (string mensaje) =>
            {
                //Al parametro recibido le vamos a concatenar .txt
                mensaje += ".txt";
                //Imprimimos la cadena completa
                Console.WriteLine(mensaje);
            };

            //Agregamos al delegado la direccion de una nueva lambda que creara un archivo y escribira en el lo que reciba por parametro
            imprime += mensaje => File.WriteAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"mensaje_lambda.txt"), mensaje);

            //Creamos un nuevo delegado y guardamos dentro de el una funcion lambda que recibe dos parametros y los muestra concatenados.
            ImprimeMensaje2 imprime2 = (string mensaje, string extension) => Console.WriteLine(mensaje + extension);

            //Mandamos a llamar el delegado.
            imprime2("hola", "txt");

            //Mandamos a llamar el metodo que recibira dos parametros un delegado(call back) y una cadena.
            RegistraMensaje(imprime,"Esto usa una expresion lambda");

            Console.ReadKey();
        }

        static void RegistraMensaje(ImprimeMensaje imprime, string mensaje)
        {
            // Invoca a los métodos registrados en el delgado
            imprime(mensaje);
        }

#region MetodosVarios
        void Metodo()
        {
            Console.WriteLine("Hola");
        }

        char Metodo2(string s)
        {
            return s[0];
        }

        void Metodo3(int[] ints)
        {
            foreach(int i in ints)
            {
                Console.WriteLine(i);
            }
        }
#endregion
    }
}
