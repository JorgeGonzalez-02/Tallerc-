﻿/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 30/10/2019
 * Time: 08:20 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto3
{
	class Program
	{
		public static void Main(string[] args)
		{
			strlen2();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		static void strlen2(){
			Console.WriteLine("Digite una cadena de texto: ");
			string texto = Console.ReadLine();
			int tamaño = texto.Length;
			Console.WriteLine("El numero de caracteres es: "+tamaño);
		}
	}
}