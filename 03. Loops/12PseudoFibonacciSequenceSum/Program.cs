namespace _12PseudoFibonacciSequenceSum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int sum = 0;

			if (n == 0)
			{
				sum = 0;
			}
			int current = 1;
			int previousOne = 0;
			int previousTwo = 0;
			for (int i = 0; i < n; i++)
			{
				sum += current;
				previousTwo = previousOne;
				previousOne = current;
				current = previousOne + previousTwo;			
			}
			Console.WriteLine(sum);
		}
	}
}
