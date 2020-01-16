using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoIntermedio_SRMT
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.Title = "PROYECTO FINAL C# INTERMEDIO";
            Comandos Com = new Comandos();
            List<string> Historial = new List<string>();
            string Actual = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            while(true)
            {
                Console.Write("\n"+Actual+"> ");
                string entrada = Console.ReadLine();
                string[] Comandos = entrada.Split(' ');
                Historial.Add(Comandos[0]);
                switch(Comandos[0])
                {   
                    case "dir":
                        string temp;
                        if (Comandos.Length > 1) 
                            temp = Comandos[1];
                        else
                            temp = Actual;
                        Com.MostrarDirectorio(temp);
                        break;
                    case "history":
                        Com.MostrarHistorial(Historial);
                        break;
                    case "cd":
                        Actual = Com.CambiarDirectorio(Actual, Comandos);
                        break;
                    case "copy":
                        Com.CopiarArchivos(Comandos);
                        break;
                    case "move":
                        Com.MoverArchivos(Comandos);
                        break;
                    case "touch":
                        Com.CrearArchivo(Actual, Comandos);
                        break;
                    case "cls":
                        Console.Clear();
                        break;
                    case "exit":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("COMANDO INVALIDO");
                        break;
                }

            }

        }
    }
}