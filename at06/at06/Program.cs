/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace at06
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um número decimal: ");
			Decimal num = Convert.ToDecimal(Console.ReadLine());
			
			Console.WriteLine("Número decimal inserido: "+ num);
			
			Console.Write("Aperte algo para fechar . . . ");
			Console.ReadKey(true);
		}
	}
}