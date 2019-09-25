/*
 * Created by SharpDevelop.
 * User: GGIZI
 * Date: 24/09/2019
 * Time: 10:58 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			string[] nombre = new string[10];
            float[] sueldo = new float[10];
            int[] op = new int[10];
            int i;


            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}º persona", i + 1);
                Console.Write("Sueldo:");
                sueldo[i] = float.Parse(Console.ReadLine());
                Console.Write("Nombre:");
                nombre[i] = Console.ReadLine();
                Console.Write("1 = Femenino, 2 = Masculino:");
                op[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (i = 0; i < 10; i++)
            {
                if (op[i] == 1 && sueldo[i] > 500 || op[i] == 2 && sueldo[i] < 400)
                    Console.WriteLine("Nombre: {0}|Sexo: {1}|Sueldo: {2}", nombre[i], op[i], sueldo[i]);
            }
            Console.Read();
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}