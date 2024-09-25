namespace _24AirlineLuggageCharges
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int weight = int.Parse(Console.ReadLine());
			int dimensions = int.Parse(Console.ReadLine());
			int charge = 0;
			bool isOverweight = false;
			bool isOvercharge = false;

			if (weight > 50)
			{
				charge += 100;
				isOverweight = true;
			}

			if (dimensions > 158)
			{
				isOvercharge = true;
				int excess = dimensions - 158;
				if (excess >= 1 && excess <= 20)
				{
					charge += 50;
				}
				else if (excess >= 21 && excess <= 50)
				{
					charge += 100;
				}
				else if (excess > 50)
				{
					charge += 200;
				}
			}
			if (isOverweight && isOvercharge)
			{
				charge += 50;
			}

			Console.WriteLine(charge);

		}
	}
}
