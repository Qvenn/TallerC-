/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 23/09/2019
 * Time: 03:58 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num,suma=0;
			double cuadrado=0,cubo=0;
			
        for (int i=1;i<=10;i++){
		Console.Write("Número: "+i+"°");
        num = int.Parse(Console.ReadLine());
        suma+=i;
        cuadrado=Math.Pow(num,2);
        cubo=Math.Pow(num,3);
        Console.WriteLine(cuadrado);
		Console.WriteLine(cubo);
        }
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}