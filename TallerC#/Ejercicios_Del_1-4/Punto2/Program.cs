/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 30/10/2019
 * Time: 08:10 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto2
{
	class Program
	{
		public static void Main(string[] args)
		{
			ultima();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static void ultima(){
			Console.WriteLine("Digite una cadena de texto: ");
			string texto = Console.ReadLine();
			if (texto != "") {
				string string2 = Convert.ToString(texto[texto.Length -1]);
				Console.WriteLine(string2);
			}else{
				Console.WriteLine("Cadena vacia");
			}
		}
	}
}