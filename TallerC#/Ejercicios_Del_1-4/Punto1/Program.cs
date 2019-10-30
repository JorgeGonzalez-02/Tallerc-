/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 30/10/2019
 * Time: 07:48 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Imc odj1 = new Imc();
			Console.Write("Digite su masa en KG: ");
			double masa= double.Parse(Console.ReadLine());
			Console.Write("Digite su altura en metros: ");
			double altura= double.Parse(Console.ReadLine());
			double imc = odj1.calcularMasaCorporal(masa,altura);
			Console.WriteLine(imc);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}