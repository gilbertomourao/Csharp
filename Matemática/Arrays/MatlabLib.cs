using System;
using System.Linq; // Para usar Zip com array de double

namespace MatlabLib
{
	public class Matlab
	{
		public static double sum(double[] vec)
		{
			double vec_sum = 0;

			foreach (double item in vec)
			{
				vec_sum += item;
			}

			return vec_sum;
		}

		public static double inner_prod(double[] vec1, double[] vec2)
		{
			double prod = 0;

			foreach (var nw in vec1.Zip(vec2, Tuple.Create)) // Cria uma tupla (vec1, vec2)
			{
				prod += nw.Item1 * nw.Item2;
			}

			return prod;
		}

		public static void cumprod(double val, double[] vec, uint begin, uint end)
		{
			vec[begin] = val;

			for (uint i = begin + 1;i <= end;i++)
			{
				vec[i] = val * vec[i-1];
			}
		}

		public static void reverse(double[] vec)
		{
			double aux;

			int vec_size = vec.Length;

			for (int i = 0; i < vec_size / 2; i++)
			{
				aux = vec[i];
				vec[i] = vec[vec_size - 1 - i];
				vec[vec_size - 1 - i] = aux;
			}
		}
	}
}