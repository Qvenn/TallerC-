/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 24/09/2019
 * Time: 10:52 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n,suma=0,x;
			Console.WriteLine("Ingresar N numero de la tabla de multiplicar");
			n=int.Parse(Console.ReadLine());
			Console.WriteLine("Ingresar hasta que numero va a ser multiplicado");
			x=int.Parse(Console.ReadLine());
			Console.WriteLine("");
			for (int i = 0; i <=x; i++) {
				Console.WriteLine((n*i));
				suma+=i;
				
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}