﻿namespace _01Marks
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double mark = double.Parse(Console.ReadLine());
			if (mark >= 5.5)
			{
				Console.WriteLine("Excellent!");
			}
		}
	}
}
