/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 24/09/2019
 * Time: 11:32 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio10
{
	class Program
	{
		public static void Main(string[] args)
		{
			float numero;
        uint cont = 0, menor = 0, mayor = 0;

        while (cont < 10)
        {
            Console.Write("Ingrese número:");
            numero = float.Parse(Console.ReadLine());

            if (numero > 0)
                mayor++;
            if (numero < 0)
                menor++;

            cont++;
        }

        Console.WriteLine("De 10 números son ...\nMenores a 0  = {0} y mayores a 0 = {1}", menor, mayor);
        Console.ReadLine();

			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}