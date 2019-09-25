/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 23/09/2019
 * Time: 02:37 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n;
			Console.WriteLine("Ingresar un numero");
			n=int.Parse(Console.ReadLine());
			for (int i=1;i<n+1;i++){
				Console.WriteLine("{0}|",i);
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}