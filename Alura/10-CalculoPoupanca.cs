using System;

namespace _10_CalculoPoupanca
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando o projeto 10");

			double valorInvestido = 1000;
			double rendimento = 0.0036; // 0.36%
			int meses = 12;
			int contadorMes = 0;

			while (contadorMes < meses)
			{
				contadorMes += 1;
				valorInvestido *= (1 + rendimento);
				Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido.ToString("F"));
			}

		}
	}
}