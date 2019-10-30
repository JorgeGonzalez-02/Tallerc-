/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 30/10/2019
 * Time: 07:52 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace tallerpart2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
//			5)	Realice un programa que contenga un método llamado calcularMayor
//			este método debe recibir tres parámetros de tipo entero y debe devolver 
//			el mayor de los tres números dados por parámetro.
			int num1,num2,num3;
			Console.WriteLine("Cual es el numero mayor");
			Console.WriteLine("Digite tres numeros");
			num1=int.Parse(Console.ReadLine());
			num2=int.Parse(Console.ReadLine());
	        num3=int.Parse(Console.ReadLine());
	        Console.WriteLine("Si el numero mayor es cero todos son iguales");
	        Console.WriteLine("El numero mayor es "+calcularMayor(num1,num2,num3));
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		static int calcularMayor(int num1, int num2,int num3){
			int mayor=0;
			if (num1==num2 && num2==num3){
				mayor=0;
			}else if (num1>num2 && num1>num3){
	
				mayor=num1;
			}else if (num2>num1 && num2>num3){
				
				mayor=num2;
			}else if (num3>num1 && num3>num2){
				
				mayor=num3;
			}
			return mayor;
		
		}
	}
}