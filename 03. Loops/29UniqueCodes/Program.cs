namespace _29UniqueCodes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int firstLimit = int.Parse(Console.ReadLine());
			int secondLimit = int.Parse(Console.ReadLine());
			int thirdLimit = int.Parse(Console.ReadLine());

			for (int i = 2; i <= firstLimit; i++)
			{
				for (int j = 2; j <= secondLimit; j++)
				{
					for (int k = 2; k <= thirdLimit; k++)
					{
						if ((i % 2 == 0) && CheckIfPrime(j) && (k % 2 == 0)) {
							Console.WriteLine($"{i}{j}{k}");
						}
					}
				}
			}
		}

		public static bool CheckIfPrime(int number)
		{
			if (number <= 3)
			{
				return true;
			}
			for (int i = 2; i < number - 1; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
