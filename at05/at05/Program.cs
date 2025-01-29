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
	        char caractere = Console.ReadKey().KeyChar; // .KeyChar adicionado
	        Console.WriteLine("\nVocê digitou: " + caractere);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
