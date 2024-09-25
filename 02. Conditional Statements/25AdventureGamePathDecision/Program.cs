using System.Threading.Channels;

namespace _25AdventureGamePathDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string itemLeft = Console.ReadLine();
			string itemRight = Console.ReadLine();

			if (itemLeft == "sword")
			{
				if (itemRight == "shield")
				{
					Console.WriteLine("Path to the casdle");
				}
				else
				{
					Console.WriteLine("Path to the forest");
				}
			}
			else if (itemLeft == "map")
			{
				if (itemRight == "coins")
				{
					Console.WriteLine("Go to the town");
				}
				else
				{
					Console.WriteLine("Camp");
				}
			}
			else
			{
				Console.WriteLine("Wander aimlessly");
			}
		}
	}
}
