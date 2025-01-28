/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 09:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace at09
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite uma palavra: ");
			string palavra = Console.ReadLine();
			
			 
			Console.WriteLine("Comprimento da palavra: " + palavra.Length + " letras");
			
			Console.Write("Aperte algo para fechar . . . ");
			Console.ReadKey(true);
		}
	}
}