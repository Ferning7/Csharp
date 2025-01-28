/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace at08
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite o preço do produto: R$");
			Double preço = Convert.ToDouble(Console.ReadLine());
			Console.Write("Desconto (%): ");
			Double ValorDesconto = Convert.ToDouble(Console.ReadLine());
			
			
			Console.WriteLine("Preço inicial do produto: "+ preço);
			
			Double PreçoDesconto = preço - (preço * ValorDesconto)/100;
			Console.WriteLine("Preço do produto com " + ValorDesconto + "% de desconto: " + PreçoDesconto);
			
			Console.Write("Aperte algo para fechar . . . ");
			Console.ReadKey(true);
		}
	}
}