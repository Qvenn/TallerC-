/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 23/09/2019
 * Time: 03:50 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			float num, may0=0, men0=1,x=0;
        int cont = 0;
        float num1, num2, auxi;

        while (cont < 10)
        {
            do
            {
                Console.Write("Número:");
                num = float.Parse(Console.ReadLine());

            } while (num == 0);

            if (num > 0)
                may0 = may0 + num;
            if (num < 0)
                men0 = men0 * num;
       
            cont++;
        }
        if (men0 == 1)// En caso de que se ingrese todos +
            men0 = 0;
        Console.Write("La suma de los números + es {0} y el producto de los - es {1}", may0, men0);
        Console.WriteLine("");
			
			// TODO: Implement Functionality Here
			
			Console.WriteLine("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}