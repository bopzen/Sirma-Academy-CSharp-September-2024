namespace _03Browser
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Stack<string> stack = new Stack<string>();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "Home")
				{
					break;
				}
				if (input == "back")
				{
					if (stack.Count <= 1)
					{
						Console.WriteLine("no previous URLs");
					}
					else
					{
						stack.Pop();
						Console.WriteLine(stack.Peek());
					}
				}
				else
				{
					stack.Push(input);
					Console.WriteLine(input);
				}
			}
		}
	}
}
