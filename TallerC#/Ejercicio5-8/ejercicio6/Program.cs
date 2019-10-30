/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 30/10/2019
 * Time: 08:08 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio6
{
	class Program
	{
		public static void Main(string[] args)
		{
//			6)	Realice un programa que calcule el diámetro, el área, 
//			la circunferencia de un círculo, para cada caracteristica utilice una función.

			double radio;
			Console.WriteLine("Caracteristicas del circulo");
			Console.WriteLine("Digite el radio del circulo");
			radio=double.Parse(Console.ReadLine());
			calcularDiametro(radio);
			calcularArea(radio);
			calcularCircunferencia(radio);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void calcularDiametro(double radio ){
			double diam;
			diam= radio*2;
			Console.WriteLine("El diametro es de "+diam);
			
		}
		
		static void calcularArea(double radio ){
			double area;
			area=Math.PI*(Math.Pow(radio,2));
			Console.WriteLine("El area es de "+area);
		}
		static void calcularCircunferencia(double radio){
			double circ;
			circ=Math.PI*(radio*2);
			Console.WriteLine("La circunferencia es de "+circ);
		}
	}
}