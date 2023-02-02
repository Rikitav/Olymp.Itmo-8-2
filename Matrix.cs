using System;
using System.Linq;
using System.Collections.Generic;

namespace Olymp
{
	public static class Itmo
	{
		public static void Main()
		{
			int N = Convert.ToInt32(Console.ReadLine());
			int[,] A = new int[N-1,N-1];
			for (int i = 0; i < N-1; i++)
			{
				for (int j = 0; j < N-1; j++)
				{
					if (i == j)
					{
						A[i, j] = i - j;
					}
					
					if (i < j)
					{
						A[i, j] = i + j;
					}
					
					if (i > j)
					{
						A[i, j] = i - j;
					}
				}
			}
			
			int Sum = 0;
			StreamWriter sw = new StreamWriter("Matrix.txt");
			for (int i = 0; i < N-1; i++)
			{
				for (int j = 0; j < N-1; j++)
				{
					sw.Write(A[i, j].ToString().PadRight(4));
					if (i + j == N + 1)
						Sum += A[i, j];
				}
				sw.WriteLine();
			}
			sw.Close();
			Console.WriteLine(Sum);
		}
	}
}