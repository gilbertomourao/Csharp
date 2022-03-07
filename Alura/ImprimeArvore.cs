using System;

namespace _ImprimeArvore
{
	class ArvoreDePontos
	{
		// Private variables
		char [,] arvore;

		// Constructor
		public ArvoreDePontos(uint altura)
		{
			uint numero_de_pontos = (altura - 1)*2 + 1;
			arvore = new char[altura, numero_de_pontos + 1];

			CriaArvore(numero_de_pontos);
		}

		void CriaArvore(uint numero_de_pontos)
		{
			uint contador_de_espacos = numero_de_pontos / 2;
			uint contador_de_pontos = 1;
			uint altura_da_arvore = (uint) arvore.GetLength(0);

			for (uint i = 0; i < altura_da_arvore; i++)
			{
				// Imprime espaços
				for (uint j = 0; j < contador_de_espacos; j++)
				{
					arvore[i,j] = ' ';
				}

				// Imprime asteríscos
				for (uint j = contador_de_espacos; 
					j < contador_de_pontos + contador_de_espacos; 
					j++)
				{
					arvore[i,j] = '*';
				}

				// Imprime espaços novamente
				for (uint j = contador_de_pontos + contador_de_espacos; 
					j < contador_de_pontos + contador_de_espacos * 2; 
					j++)
				{
					arvore[i,j] = ' ';
				}

				// Insere o '\n' no final
				arvore[i,contador_de_pontos + contador_de_espacos * 2] = '\n';

				contador_de_espacos -= 1;
				contador_de_pontos += 2;
			}
		}

		// Métodos
		public void ImprimeArvore()
		{
			foreach (char ch in arvore)
			{
				Console.Write(ch);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			uint linhas = 20;
			
			ArvoreDePontos tree = new ArvoreDePontos(linhas);

			tree.ImprimeArvore();
		}
	}
}