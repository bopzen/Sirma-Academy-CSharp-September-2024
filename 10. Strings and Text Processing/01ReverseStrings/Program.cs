﻿namespace _01ReverseStrings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				string input = Console.ReadLine();
				if (input == "end")
				{
					break;
				}

				string reversedInput = "";
				for (int i = input.Length - 1; i >= 0; i--)
				{
					reversedInput += input[i];
				}
				Console.WriteLine($"{input} = {reversedInput}");
			}
		}
	}
}
