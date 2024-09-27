namespace _10FactorialCalculation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int factorial = 1;
			for (int i = n; i >= 1; i--)
			{
				factorial *= i;
			}
			Console.WriteLine(factorial);

		}
	}
}
