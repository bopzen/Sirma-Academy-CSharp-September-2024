namespace _05DecimalToBinaryConverter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			Stack<int> stack = new Stack<int>();
			if (number == 0) {
				Console.WriteLine(0);
			}
			while (number > 0)
			{
				stack.Push(number % 2);
				number /= 2;
			}
			while (stack.Count > 0)
			{
				Console.Write(stack.Pop());
			}
		}
	}
}
