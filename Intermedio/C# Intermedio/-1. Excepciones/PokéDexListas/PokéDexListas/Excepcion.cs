using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokéDexListas
{
    public class NullData : Exception
    {
        // Constructor default
        public NullData()
        {
            // Vacío
        }

        // Constructor con un mensaje de error
        public NullData(string message) : base("No puedes introducir datos vacíos")
        {
            // Vacío
        }

        // Constructor con mensaje de error y excepción adicional
        public NullData(string message, Exception innerException) : base(message)
        {
            // Vacío
        }
    }
}
