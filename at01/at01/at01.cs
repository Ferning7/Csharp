
 using System;

namespace at01
{
	class at01
	{
		public static void Main(string[] args)
		{
			
			Console.Write("Digite um número inteiro: ");
			int num = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Número Digitado: " + num);
			
			Console.Write("Pressione para fechar");
			Console.ReadKey(true);
		}
	}
} 