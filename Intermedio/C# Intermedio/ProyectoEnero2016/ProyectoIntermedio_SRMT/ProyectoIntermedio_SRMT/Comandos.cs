using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoIntermedio_SRMT
{
    public class Comandos
    {
        public void CrearArchivo(string actual, string[] Comandos)
        {
            try
            {
                if (Comandos.Length != 2)
                    Console.WriteLine("touch debe tener 1 argumento");
                else
                {
                    string direccion;
                    if (Comandos[1].Contains(":\\"))
                        direccion = Comandos[1];
                    else
                        direccion = Path.Combine(actual, Comandos[1]);
                    if (Directory.Exists(Path.GetDirectoryName(direccion)))
                        if (!File.Exists(direccion))
                            File.Create(direccion);
                        else Console.WriteLine("El archivo ya existe");
                    else
                        Console.WriteLine("La direccion no existe");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Permiso denegado");
            }
        }

        public void MoverArchivos(string[] Argumentos)
        {
            try
            {
                if (Argumentos.Length != 3)
                    Console.WriteLine("move debe tener 2 argumentos");
                else
                    if (File.Exists(Argumentos[1]))
                        if (Directory.Exists(Path.GetDirectoryName(Argumentos[2])))
                            if (!File.Exists(Argumentos[2]))
                                File.Move(Argumentos[1], Argumentos[2]);
                            else
                                Console.WriteLine("El archivo {0} ya existe");
                        else
                            Console.WriteLine("El directorio destino: {0} no existe", Path.GetDirectoryName(Argumentos[2]));
                    else
                        Console.WriteLine("El arvhivo a mover no existe");

            }
            catch (Exception)
            {
                Console.WriteLine("Permiso denegado");
            }
        }

        public void CopiarArchivos(string[] Argumentos)
        {
            try
            {
                if (Argumentos.Length != 3)
                    Console.WriteLine("copy debe tener 2 argumentos");
                else
                    if (File.Exists(Argumentos[1]))
                        if (Directory.Exists(Path.GetDirectoryName(Argumentos[2])))
                            if (!File.Exists(Argumentos[2]))
                                File.Copy(Argumentos[1], Argumentos[2]);
                            else
                                Console.WriteLine("El archivo {0} ya existe");
                        else
                            Console.WriteLine("El directorio destino: {0} no existe", Path.GetDirectoryName(Argumentos[2]));
                    else
                        Console.WriteLine("El arvhivo a copiar no existe");

            }
            catch (Exception)
            {
                Console.WriteLine("Permiso Denegado");
            }
        }

        public string CambiarDirectorio(string Actual, string[] Comandos)
        {
            if (Comandos.Length != 2)
            {
                Console.WriteLine("cd debe recibir 1 argumento");
                return Actual;
            }
            else
            {
                try
                {
                    if (Comandos[1] == "..")
                    {
                        return Path.GetDirectoryName(Actual);
                    }
                    else
                    {
                        string Nueva;
                        if (Comandos[1].Contains(":\\"))
                            Nueva = Comandos[1];
                        else
                            Nueva = Path.Combine(Actual, Comandos[1]);
                        if (Directory.Exists(Nueva))
                        {
                            return Nueva;
                        }
                        else
                        {
                            Console.WriteLine("El fichero Especificado no existe");
                            return Actual;
                        }
                    }

                }
                catch (Exception es)
                {
                    System.Console.WriteLine(es.Message);
                    return Actual;
                }
            }

        }

        public void MostrarHistorial(List<string> Historial)
        {
            foreach (string s in Historial)
            {
                Console.WriteLine(s);
            }
        }

        public void MostrarDirectorio(string direccion)
        {

            try
            {
                if (Directory.Exists(direccion))
                {
                    DirectoryInfo directorio = new DirectoryInfo(direccion);
                    DirectoryInfo[] carpetas = directorio.GetDirectories();
                    Console.WriteLine("CARPETAS: ");
                    foreach (DirectoryInfo c in carpetas)
                    {
                        Console.WriteLine(c.Name);
                    }
                    FileInfo[] files = directorio.GetFiles();
                    Console.WriteLine("ARCHIVOS: ");
                    foreach (FileInfo f in files)
                    {
                        Console.WriteLine(f.Name);
                    }
                }
                else
                {
                    Console.WriteLine("Fichero no valido");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Fichero no valido");
            }


        }
    }
}
