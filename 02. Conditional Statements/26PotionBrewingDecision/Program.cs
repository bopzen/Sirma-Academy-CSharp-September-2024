namespace _26PotionBrewingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string ingredientOne = Console.ReadLine();
			string ingredientTwo = Console.ReadLine();

			if (ingredientOne == "herbs")
			{
				if (ingredientTwo == "water")
				{
					Console.WriteLine("Health potion");
				}
				else if (ingredientTwo == "oil")
				{
					Console.WriteLine("Stealth potion");
				}
				else
				{
					Console.WriteLine("Minor stamina potion");
				}
			}
			else if (ingredientTwo == "berries")
			{
				if (ingredientTwo == "berries")
				{
					Console.WriteLine("Speed potion");
				}
				else
				{
					Console.WriteLine("Minor energy potion");
				}
			}
			else
			{
				Console.WriteLine("No potion");
			}

		}
	}
}
