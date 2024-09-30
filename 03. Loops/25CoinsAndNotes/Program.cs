namespace _25CoinsAndNotes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int oneLev = int.Parse(Console.ReadLine());
			int twoLev = int.Parse(Console.ReadLine());
			int fiveLev = int.Parse(Console.ReadLine());
			int amount = int.Parse(Console.ReadLine());

			for (int i = 0; i <= oneLev; i++)
			{
				for (int j = 0; j <= twoLev; j++)
				{
					for(int k = 0; k <= fiveLev; k++)
					{
						if (i * 1 + j * 2 + k * 5 == amount)
						{
							Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {amount} lv.");
						}
					}
				}
			}
		}
	}
}
