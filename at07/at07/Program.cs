/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:46
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace at07
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite seu nome: ");
			string nome = Console.ReadLine();
			Console.Write("Digite sua idade: ");
			int idade = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Você se chama " + nome + " e tem " + idade + " anos");
			
			Console.Write("Aperte algo para fechar . . . ");
			Console.ReadKey(true);
		}
	}
}