using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ArchivosFlujos
{
    /// <summary>
    /// Archivos y Flujos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Create a file called test.txt in the current directory:    CarpetaArchivo\bin\Debug
            using (Stream s = new FileStream("test.txt", FileMode.Create))
            {
                Console.WriteLine(s.CanRead);  // True
                Console.WriteLine(s.CanWrite); // True
                Console.WriteLine(s.CanSeek);  // True
                
                //Escribimos los bytes 101 y 102
                s.WriteByte(101);
                s.WriteByte(102);
                
                //Definimos un arreglo de bytes
                byte[] block = { 1, 2, 3, 4, 5 };
                
                
                //Transforma la cadena de texto en bytes de formato ASCII, para que al leerla el Stream 
				//interprete los bytes de acuerdo al codigo ASCII                
                byte[] block2 = Encoding.ASCII.GetBytes("Hola Mundo");
                for(int i = 0; i < block2.Length ; i++){
                	Console.WriteLine(block2[i]);
                }
                
                
                s.Write(block, 0, block.Length);    // Write block of 5 bytes
                Console.WriteLine(s.Length);        // 7
                s.Write(block2, 0, block2.Length);
                Console.WriteLine(s.Length);
                
                //s.Position nos regresara la ultima posicion del la secuencia
                Console.WriteLine(s.Position);      // 7
                s.Position = 0;                     // Move back to the start
                Console.WriteLine(s.ReadByte());    // 101
                Console.WriteLine(s.ReadByte());    // 102

                // Read from the stream back into the block array:
                Console.WriteLine(s.Read(block, 0, block.Length)); // 5
                // Assuming the last Read returned 5, we'll be at
                // the end of the file, so Read will now return 0:
                Console.WriteLine(s.Read(block2, 0, block2.Length)); // 0
                
                Console.ReadKey();
            }

            // using cierra el archivo al terminar
        }
    }
}
