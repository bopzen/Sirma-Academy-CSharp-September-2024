namespace _16AtSea
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int days = int.Parse(Console.ReadLine());
			string roomType = Console.ReadLine();
			string assessment = Console.ReadLine();
			double cost = 0;
			int nights = days - 1;

			if (roomType == "single")
			{
				cost = nights * 25;
			}
			else if (roomType == "apartment")
			{
				cost = nights * 50;
				if (days < 10)
				{
					cost -= cost * 0.3;
				} 
				else if (days <= 15) 
				{
					cost -= cost * 0.35;
				}
				else
				{
					cost -= cost * 0.5;
				}
			}
			else if (roomType == "presidential")
			{
				cost = nights * 100;
				if (days < 10)
				{
					cost -= cost * 0.1;
				}
				else if (days <= 15)
				{
					cost -= cost * 0.15;
				}
				else
				{
					cost -= cost * 0.2;
				}
			}
			else
			{
				Console.WriteLine("error");
			}

			if (assessment == "positive")
			{
				cost += cost * 0.25;
			}
			else if (assessment == "negative")
			{
				cost -= cost * 0.1;
			}

			Console.WriteLine($"{cost:F2}");
		}
	}
}
