/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 30/10/2019
 * Time: 08:44 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ejercicio8
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*8)	A un trabajador le pagan según sus horas y una tarifa de pago por horas. 
 * 			Si la cantidad de horas trabajadas es mayor a 44 horas, la tarifa se incrementa en un
 * 			 25% para las horas extras. Hacer un algoritmo que calcule el salario del trabajador
 * 			 dadas las horas trabajadas y la tarifa. Una función debe realizar el calculo del salario del empleado. 
 * 			La función debe ser void y debe tener como parámetros el nombre del trabajado y la cantidad de horas 
 * 			trabajadas.
 */
 			
			String nombre;
			int horas;
			double tarifa;
			Console.WriteLine("Digite su nombre");
			nombre=Console.ReadLine();
			Console.WriteLine("Digite las horas trabajadas");
			horas = int.Parse(Console.ReadLine());
			Console.WriteLine("Digite la tarifa");
			tarifa=double.Parse(Console.ReadLine());
			salario(nombre,tarifa,horas);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		static void salario(String nombre,double tarifa,int horas){
			double sfinal;
			if (horas > 44) {
				tarifa=tarifa+(tarifa*0.25);
			sfinal=horas*tarifa;
			}else {
				sfinal=horas*tarifa;
				
			}
			Console.WriteLine("Trabajador: "+nombre);
			Console.WriteLine("Su salario sera de: "+sfinal);
			Console.WriteLine(tarifa);
		}
		
		}
}