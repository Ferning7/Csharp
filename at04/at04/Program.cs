
using System;

namespace at04
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite sim ou não: ");
			string escolha = Console.ReadLine();
			
			bool check = (escolha == "sim" || escolha == "Sim" || escolha == "SIM") ? true : false;
			
			Console.WriteLine(check);
			
			Console.Write("Aperte algo para fechar . . . ");
			Console.ReadKey(true);
		}
	}
}