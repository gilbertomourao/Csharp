using System;

namespace _6_AtribuicoesDeVariaveis
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando o projeto 6");

			int idade = 32;
			int idadeGustavo = idade;

			Console.WriteLine(idade + idadeGustavo); // Não concatena, apenas soma
		}
	}
}