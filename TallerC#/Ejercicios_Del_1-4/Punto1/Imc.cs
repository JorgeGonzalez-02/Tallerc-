/*
 * Created by SharpDevelop.
 * User: CBN
 * Date: 30/10/2019
 * Time: 07:53 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Punto1
{
	/// <summary>
	/// Description of Imc.
	/// </summary>
	public class Imc
	{
		public Imc()
		{
		}
		public double  calcularMasaCorporal (double peso, double estatura)
		{
			double imc = peso/(estatura*estatura);
			return imc;
		}
	}
}
