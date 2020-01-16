/*
 * Created by SharpDevelop.
 * User: arman
 * Date: 15/06/2017
 * Time: 08:41 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ParametrosConNombre
{
	class Program
	{
		public static void Main(string[] args)
		{
			float weight, height, imc;
			
			//Pedimos estatura y peso al usuario
			Console.WriteLine("Ingresa tu peso en kilos: ");
			weight = float.Parse(Console.ReadLine());
			
			Console.WriteLine("Ingresa tu estatura en metros: ");
			height = float.Parse(Console.ReadLine());
			
			//Paso de parametros normal
			imc = IMC(weight, height);
			Console.WriteLine("El indice de masa corporal es: "+imc);
			
			//Paso de parametros con nombre
			imc = IMC(estatura:height, peso:weight);
			Console.WriteLine("El indice de masa corporal es: "+imc);
			
			//Lo que nunca se debe hacer
			//imc = IMC(estatura:height, weight);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static float IMC(float peso, float estatura){
			return peso/(estatura * estatura);
		}
		
	}
}