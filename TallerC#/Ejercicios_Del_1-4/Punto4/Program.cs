/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 30/10/2019
 * Time: 08:37 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Numero entero digitado: "+pedir());
			Console.WriteLine("Digite el parametro para la funcion triple: ");
			int parametro=int.Parse(Console.ReadLine());
			Console.WriteLine("El triple de "+parametro+" es: "+triple(parametro));
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static int pedir(){
			Console.WriteLine("Digite un numero entero");
			int numero = int.Parse(Console.ReadLine());
			return numero;
		}
		static int triple(int valor){
			int numeroTriple=valor*3;
			return numeroTriple;
		}
	}
}