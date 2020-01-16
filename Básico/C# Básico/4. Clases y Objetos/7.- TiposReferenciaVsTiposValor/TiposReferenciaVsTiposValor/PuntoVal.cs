using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiposReferenciaVsTiposValor
{
    public struct PuntoVal
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PuntoVal(int x, int y) 
        {
            X = x;
            Y = y;
        }
    }
}
