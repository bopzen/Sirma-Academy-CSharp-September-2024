using System.ComponentModel;

namespace _17NewBuilding
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int floors = int.Parse(Console.ReadLine());
			int rooms = int.Parse(Console.ReadLine());

			for (int floor = floors; floor >= 1; floor--)
			{
				string type = "";
				if (floor == floors)
				{
					type = "L";
				}
				else if (floor % 2 == 0)
				{
					type = "O";
				}
				else
				{
					type = "A";
				}
				for (int room = 0; room < rooms; room++)
				{
					Console.Write($"{type}{floor}{room} ");
				}
				Console.WriteLine();
			}
		}
	}
}
