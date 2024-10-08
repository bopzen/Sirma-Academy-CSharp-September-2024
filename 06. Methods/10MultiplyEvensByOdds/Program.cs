namespace _10MultiplyEvensByOdds
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine(MultiplyEvenByOdd(number));
		}

		static int MultiplyEvenByOdd(int number)
		{
			int sumEven = 0;
			int sumOdd = 0;
			while (number > 0)
			{
				int digit = number % 10;
				if (digit % 2 == 0)
				{
					sumEven += digit;
				}
				else
				{
					sumOdd += digit;
				}
				number /= 10;
			}
			return sumEven * sumOdd;
		}
	}
}
