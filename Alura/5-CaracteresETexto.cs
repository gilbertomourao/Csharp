using System;

namespace _5_CaracteresETexto
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Executando o projeto 5");

			char primeiraLetra = 'a';

			Console.WriteLine(primeiraLetra + "" + (char)65);

			string titulo = "Alura Cursos de Tecnologia " + 2020;

			Console.WriteLine(titulo);

			// O @ permite a quebra da string em várias linhas
			string cursosProgramacao = @"
 - .NET
 - Java
 - Javascript";

			Console.WriteLine(cursosProgramacao);
		}
	}
}