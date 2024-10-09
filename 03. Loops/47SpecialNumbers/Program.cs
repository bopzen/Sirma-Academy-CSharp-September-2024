namespace _47SpecialNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1111; i <= 9999; i++)
			{
				bool isSpecial = true;
				int current = i;
				while (current > 0)
				{
					int digit = current % 10;
					if (digit == 0)
					{
						isSpecial = false;
						break;
					}

					if (n % digit != 0)
					{
						isSpecial = false;
						break;
					}
					current /= 10;
				}
				if (isSpecial)
				{
					Console.WriteLine(i);
				}
			}
		}
	}
}
