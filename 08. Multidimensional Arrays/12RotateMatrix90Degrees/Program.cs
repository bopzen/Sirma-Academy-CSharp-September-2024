﻿namespace _12RotateMatrix90Degrees
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int m = size[0];
			int n = size[1];
			int[,] matrix = new int[m, n];

			for (int i = 0; i < m; i++)
			{
				int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
				for (int j = 0; j < n; j++)
				{
					matrix[i, j] = row[j];
				}
			}

			for (int j = 0; j < n; j++)
			{
				for (int i = m-1;  i >= 0; i--)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
