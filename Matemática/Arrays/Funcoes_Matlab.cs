using System;
using System.Linq; // Para usar Zip com array de double
using MatlabLib;

namespace _My_Program
{
	class Program
	{
		public static void PrintArray(double[] arr)
		{
			Console.WriteLine("[{0}]", string.Join(", ", arr));
		}

		static void Main(string[] args)
		{
			double[] vec = new double[] {1,2,3};
			double[] vec2 = new double[] {3,2,1};

			Console.WriteLine(Matlab.sum(vec));
			Console.WriteLine(Matlab.inner_prod(vec, vec2));
			Matlab.cumprod(10, vec, 0, 2);
			PrintArray(vec);
			Matlab.reverse(vec);
			PrintArray(vec);
		}
	}
}