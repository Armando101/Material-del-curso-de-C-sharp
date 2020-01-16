using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ManejoSistemaArchivos
{
    /// <summary>
    /// Manejo del sistema de archivos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {     
        	/*Proporciona informacion hacerca del SO y el entorno (Directorio) en el cual se esta trabajando, 
        	 *solo obtiene la informacion mas importante del sistema o que ya viene predefinida.
        	 * 
        	 * El metodo GetFolderPath nos regresa la ruta de acceso a alguna carpeta especial de sistema
        	 * SpecialFolder: Constante enumerada que identifica una carpeta especial del sistema
        	 */
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Console.WriteLine(rutaDocumentos);
            
            
            /*Ejecuta operaciones en estancias de String que contienen informacion de rutas de acceso o directorios
             * La operacion que esta realizando en la parte de abajo es anexar el nombre de nuestro archivo a la ruta definida
             */
            string nombre = Console.ReadLine();
            string ruta = Path.Combine(rutaDocumentos, nombre+".txt");
            Console.WriteLine(ruta);
            
            
            if (!File.Exists(ruta))
            {
                File.Create(ruta);
            }
			
            
            // Información sobre archivos clases File, FileInfo
            FileInfo fInfo = new FileInfo(ruta);
            //fInfo.Create();    De no poner esta linea nos generara una excepcion si tenemos comentado el if de arriba
            Console.WriteLine("Nombre: {0}", fInfo.Name);
            Console.WriteLine("Extensión: {0}", fInfo.Extension);
            Console.WriteLine("Existe? {0}", fInfo.Exists);
            Console.WriteLine("Tamaño: {0} B", fInfo.Length);
            Console.WriteLine("Directorio contenedor: {0}", fInfo.Directory);
            Console.WriteLine("Fecha de creación: {0}", fInfo.CreationTime);

            
            
            // Información sobre directorios clases Directory, DirectoryInfo
            Console.WriteLine("\n\nInformación sobre la carpeta Mis Documentos");                                   
            DirectoryInfo dInfo = new DirectoryInfo(rutaDocumentos);
            Console.WriteLine("Ruta: {0}", dInfo.FullName);
            
            
            // Mostrar todos los archivos dentro de este directorio
            Console.WriteLine("\nArchivos");
            foreach (var file in dInfo.GetFiles())
            {
                Console.WriteLine(file.Name);
            }

            
            
            Console.WriteLine("\nDirectorios");
            // Mostrar todos los subdirectorios dentro de este directorio
            foreach (var dir in dInfo.GetDirectories())
            {
                Console.WriteLine(dir.Name);
            }

            
            Console.ReadKey();
        }
    }
}
