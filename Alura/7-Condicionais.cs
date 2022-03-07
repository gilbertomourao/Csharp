using System;

namespace _7_Condicionais
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando o projeto 7");

			int idadeJoao = 16;

			if (idadeJoao >= 18)
			{
				Console.WriteLine("Joao pode entrar na boate.");
			}
			else 
			{
				Console.WriteLine("Joao nao pode entrar.");
			}
		}
	}
}