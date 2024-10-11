using System.Diagnostics.CodeAnalysis;

namespace _06MatchingBrackets
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string expression = Console.ReadLine();
			Stack<int> stack = new Stack<int>();
			for (int i = 0; i < expression.Length; i++)
			{
				if (expression[i] == '(')
				{
					stack.Push(i);
				}
				else if (expression[i] == ')')
				{
					int startIndex = stack.Pop();
					for (int j = startIndex; j <= i; j++)
					{
						Console.Write(expression[j]);
					}
					Console.WriteLine();
				}
				
			}
		}
	}
}
