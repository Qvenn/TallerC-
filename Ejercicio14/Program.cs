/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 24/09/2019
 * Time: 11:34 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio14
{
	class Program
	{
		public static void Main(string[] args)
		{
			String cadena="";
			
			
			for (int i = 1; i <=20; i++) {
				cadena= cadena+i;
				Console.WriteLine(cadena);
			}
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}