
using System;

namespace at02
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um número real: ");
			Double num = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Número inserido: "+ num);
			
			Console.WriteLine("Aperte algo para fechar . . . ");
			Console.ReadKey(true);
		}
	}
}