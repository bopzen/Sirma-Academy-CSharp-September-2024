﻿namespace _38PyramidWithIncreasingDigits
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= n-i; j++)
				{
					Console.Write(" ");
				}
				int r = i;
				for (int j = 1; j < i; j++)
				{
					Console.Write(r++);
				}
				Console.Write(r--);
				for (int j = 1; j < i; j++)
				{
					Console.Write(r--);
				}
				Console.WriteLine();
			}
		}
	}
}