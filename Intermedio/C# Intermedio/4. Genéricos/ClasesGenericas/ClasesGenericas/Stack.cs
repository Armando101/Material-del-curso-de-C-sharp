using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesGenericas
{
    public class Stack<T>
    {
        private int position;
        private T[] data;

        public Stack() {
            data = new T[10];
        }

        public Stack(int largo)
        {
            data = new T[largo];
        }

        public void Push(T obj) 
        { 
            data[position++] = obj; 
        }

        public T Pop() 
        { 
            return data[--position]; 
        }
    }
}
