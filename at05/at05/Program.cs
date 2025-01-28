/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace at05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um caractere: ");
			char caractere = Convert.ToChar(Console.ReadLine());
			
			Console.WriteLine("Caractere inserido: "+ caractere);
			
			Console.Write("Aperte algo para fechar . . . ");
			Console.ReadKey(true);
		}
	}
}