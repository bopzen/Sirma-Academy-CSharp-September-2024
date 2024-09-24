namespace _14Holiday
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			if (budget <= 100)
			{
				Console.WriteLine("Somewhere in Bulgaria");
				if (season == "summer")
				{
					Console.WriteLine($"Camp - {(budget * 0.3):F2}");
				}
				else if (season =="winter")
				{
					Console.WriteLine($"Hotel - {(budget * 0.7):F2}");
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (budget <= 1000)
			{
				Console.WriteLine("Somewhere in Europe");
				if (season == "summer")
				{
					Console.WriteLine($"Camp - {(budget * 0.4):F2}");
				}
				else if (season == "winter")
				{
					Console.WriteLine($"Hotel - {(budget * 0.8):F2}");
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else
			{
				Console.WriteLine("Somewhere in Asia");
				Console.WriteLine($"Hotel - {(budget * 0.9):F2}");
			}
		}
	}
}
