namespace _13VegetableMarket
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string vegetable = Console.ReadLine();
			string weekday = Console.ReadLine();
			double quantity = double.Parse(Console.ReadLine());
			if (vegetable == "tomato")
			{
				if (weekday == "Saturday" || weekday == "Sunday")
				{
					Console.WriteLine($"{(quantity * 2.8):F2}");
				}
				else if (weekday == "Monday" || weekday == "Tuesday" || weekday == "Wednesday" || weekday == "Thursday" || weekday == "Friday")
				{
					Console.WriteLine($"{(quantity * 2.5):F2}");
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (vegetable =="onion")
			{
				if (weekday == "Saturday" || weekday == "Sunday")
				{
					Console.WriteLine($"{(quantity * 1.3):F2}");
				}
				else if (weekday == "Monday" || weekday == "Tuesday" || weekday == "Wednesday" || weekday == "Thursday" || weekday == "Friday")
				{
					Console.WriteLine($"{(quantity * 1.2):F2}");
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (vegetable == "lettuce")
			{
				if (weekday == "Saturday" || weekday == "Sunday")
				{
					Console.WriteLine($"{(quantity * 0.85):F2}");
				}
				else if (weekday == "Monday" || weekday == "Tuesday" || weekday == "Wednesday" || weekday == "Thursday" || weekday == "Friday")
				{
					Console.WriteLine($"{(quantity * 0.85):F2}");
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (vegetable == "cucumber")
			{
				if (weekday == "Saturday" || weekday == "Sunday")
				{
					Console.WriteLine($"{(quantity * 1.75):F2}");
				}
				else if (weekday == "Monday" || weekday == "Tuesday" || weekday == "Wednesday" || weekday == "Thursday" || weekday == "Friday")
				{
					Console.WriteLine($"{(quantity * 1.45):F2}");
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (vegetable == "pepper")
			{
				if (weekday == "Saturday" || weekday == "Sunday")
				{
					Console.WriteLine($"{(quantity * 3.5):F2}");
				}
				else if (weekday == "Monday" || weekday == "Tuesday" || weekday == "Wednesday" || weekday == "Thursday" || weekday == "Friday")
				{
					Console.WriteLine($"{(quantity * 5.5):F2}");
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else
			{
				Console.WriteLine("error");
			}
		}
	}
}
