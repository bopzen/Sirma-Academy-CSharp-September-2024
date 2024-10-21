namespace _18WarGame
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> playerOne = Console.ReadLine().Split(" ").Select(int.Parse).ToHashSet();
			HashSet<int> playerTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToHashSet();

			for (int i = 0; i < 50; i++)
			{


				if (playerOne.Count() == 0)
				{
					break;
				}
				if (playerTwo.Count() == 0)
				{
					break;
				}
			}
		}
	}
}
