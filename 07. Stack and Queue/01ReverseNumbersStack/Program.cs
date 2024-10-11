namespace _01ReverseNumbersStack
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

			Stack<int> stack = new Stack<int>();
			foreach (var number in numbers)
			{
				stack.Push(number);
			}

			while (stack.Count > 0)
			{
				Console.Write(stack.Pop()+ " ");
			}
		}
	}
}
