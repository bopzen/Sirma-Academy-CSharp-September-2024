﻿namespace _02BasicStackOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int n = input[0];
			int s = input[1];
			int x = input[2];

			int[] numbersArray = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

			Stack<int> stack = new Stack<int>();

			for (int i = 0; i < n; i++)
			{
				stack.Push(numbersArray[i]);
			}

			int counter = 1;
			while (stack.Count > 0)
			{
				if (counter > s)
				{
					break;
				}
				stack.Pop();
				counter++;
			}

			if (stack.Count == 0)
			{
				Console.WriteLine(0);
			}
			else
			{
				bool isFound = false;
				int minNumber = int.MaxValue;

				foreach (int number in stack)
				{
					if (number == x)
					{
						isFound = true;
						break;
					}
					if (number < minNumber)
					{
						minNumber = number;
					}
				}
				if (isFound)
				{
					Console.WriteLine("true");
				}
				else
				{
					Console.WriteLine(minNumber);
				}
			}
		}
	}
}