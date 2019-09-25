/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 24/09/2019
 * Time: 10:25 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			int x,cont = 0, men0 = 0, may0 = 0;
		
        do
        {       
            Console.Write("\nIngrese peso:");
            x= int.Parse(Console.ReadLine());

            if (num1 > 0)
            {
                if (x <= 80000)
                    men0 = men0 + 1;
                if (x > 80000)
                    may0 = may0 + 1;

                cont++;
            }
            else
                Console.Write("\nDebe ingresar mayor a 0\n");

            Console.Write("\nDesea continuar s/n ?");// VALIDAR
        } while (Console.ReadLine() == "s");
        Console.Write("\n\nDe {0} persona/s {1} pesan menos o igual a 80 Kg y {2} pesan mas de 80 Kg",cont,men0,may0);
        Console.Read();

    
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}