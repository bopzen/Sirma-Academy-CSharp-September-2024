﻿namespace _42LeftArrowPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i < n; i++)
			{
				for (int j = 1; j <= n-i-1; j++)
				{
					Console.Write(" ");
				}
				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			for (int i = n-2; i >= 1; i--)
			{
				for (int j = 1; j <= n - i - 1; j++)
				{
					Console.Write(" ");
				}
				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

		}
	}
}
