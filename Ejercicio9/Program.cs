/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 24/09/2019
 * Time: 11:10 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio9
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n,cantidad=0,promedio=0;
			for (int i = 1; i <=5; i++) {
				Console.WriteLine("Ingresar "+i+" ° numero");
				n=int.Parse(Console.ReadLine());
				cantidad=n+i;
				promedio=n;
				Console.WriteLine("El promedio de "+n+" es: "+(n/promedio));
			}
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}