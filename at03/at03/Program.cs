/*
 * Created by SharpDevelop.
 * User: Aluno_Manha
 * Date: 28/01/2025
 * Time: 08:18
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace at03
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um número flutuante: ");
			float num = float.Parse(Console.ReadLine());
			
			Console.WriteLine("Número inserido: "+ num);
			
			Console.WriteLine("Aperte algo para fechar . . . ");
			Console.ReadKey(true);
		}
	}
}