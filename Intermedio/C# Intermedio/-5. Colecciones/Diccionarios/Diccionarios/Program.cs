using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Diccionarios
{
    /// <summary>
    /// Uso de la clase Dictionary<K, V>
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> values = new Dictionary<string, string>();

            values.Add("Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");

            // Revisa si el diccionario contiene una llave
            if (values.ContainsKey("Juan") )
            {                
                string numero = values["Juan"]; // accede al valor de la llave
                Console.WriteLine(numero);
            }

            string nombre;
            if (values.TryGetValue("Jorge", out nombre)) 
            {
                Console.WriteLine(nombre); 
            }
            else
            {
                Console.WriteLine("No contiene la llave");
            }

            // Mostrar todas las entradas en el diccionario
            // KeyValuePair<string, string> se puede reemplazar por var
            foreach (var entrada in values)
            {
                Console.WriteLine("{0}, {1}", entrada.Key, entrada.Value);
            }

            // cambiar el valor de una llave
            values["Mariana"] = "58251425";
            Console.WriteLine("Nuevo teléfono de Mariana: {0}", values["Mariana"]);

            dynamic d = 1;
            var testSum = d + 3;
            // Rest the mouse pointer over testSum in the following statement.
            System.Console.WriteLine(testSum);
        }
    }
}
