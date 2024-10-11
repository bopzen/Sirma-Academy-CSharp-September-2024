namespace _04SimpleCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(" ");
			Stack<string> stack = new Stack<string>();
			for (int i = 0; i < input.Length; i++)
			{
				stack.Push(input[i]);
			}

			int sum = 0;
			while (stack.Count > 0)
			{
				int current = int.Parse(stack.Pop());
				string operation = "";
				if (stack.Count > 0)
				{
					operation = stack.Pop();
				}

				if (operation == "-")
				{
					current = -current;
				}

				sum += current;

			}
			Console.WriteLine(sum);
		}
	}
}
