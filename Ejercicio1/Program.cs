/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 23/09/2019
 * Time: 02:27 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n, suma=0;
			Console.WriteLine("Ingresar un numero que muestre la suma de los numero que lo anteceden:");
			n=int.Parse(Console.ReadLine());
			for(int i=n;i>=0;i--) {
				suma+=i;
			}
			Console.WriteLine("El resultado de "+n+" mas los numeros que le anteceden es: "+suma);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}