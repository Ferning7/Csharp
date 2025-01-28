
using System;

namespace at10
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite seu endereço: ");
			
			Console.Write("Rua: ");
			string rua = Console.ReadLine();
			
			Console.Write("Número: ");
			string numCasa = Console.ReadLine();
			
			Console.Write("Bairro: ");
			string bairro = Console.ReadLine();
			
			Console.Write("Cidade: ");
			string cidade = Console.ReadLine();
			
			Console.Write("Estado: ");
			string estado = Console.ReadLine();
			
			Console.WriteLine(" ");
			Console.WriteLine("Endereço: " + rua + ", " + numCasa + ", " + bairro + ", " + cidade + " - " + estado);
			
			Console.Write("Aperte algo para fechar . . . ");
			Console.ReadKey(true);
		}
	}
}