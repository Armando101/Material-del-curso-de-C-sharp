/*
 * Created by SharpDevelop.
 * User: arman
 * Date: 15/06/2017
 * Time: 08:26 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace OutRef
{
	class Program
	{
		public static void Main(string[] args)
		{
			String cadena = "Pedro", cadena2;

			Console.WriteLine(cadena);
			
			//Metodo Ref, recibe un argumento inicializado.
			MetodoRef(ref cadena);
			Console.WriteLine(cadena);
			
			//Metodo Out
			MetodoOut(out cadena2);
			Console.WriteLine(cadena2);
			
			Console.ReadKey(true);
		}
		
		public static void MetodoRef(ref String palabra){
			palabra = "Hola mundo";
		}
		
		public static void MetodoOut(out String frase){
			frase = "Te quiero";
		}
	}
}