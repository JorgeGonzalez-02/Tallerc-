/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 30/10/2019
 * Time: 08:38 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio7
{
	class Program
	{
		public static void Main(string[] args)
		{
//			7)	Realice un programa que muestre la tabla de multiplicar de un número. 
//			El numero debe ser pasado como argumento a una función llamada mostrarTabla
			int num;
			Console.WriteLine("Digite un numero: ");
			num= int.Parse(Console.ReadLine());
			mostrarTabla(num);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void  mostrarTabla(int num){
			int tabla;
			
			Console.WriteLine("La tabla de este numero es :");
			for (int i = 1; i < 12; i++) {
				tabla=num*i;
				Console.WriteLine(tabla);
			}
		}
	}
}