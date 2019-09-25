/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 23/09/2019
 * Time: 03:05 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n,suma=0;
			Console.WriteLine("Ingrese un numero:");
			n=int.Parse(Console.ReadLine());
			for (int i=0; i<n;i++)
				if (i%5==0)
					suma++;
			Console.WriteLine("Entre el 1 y el {0} hay {1} multiplos de 5",n,suma);
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}