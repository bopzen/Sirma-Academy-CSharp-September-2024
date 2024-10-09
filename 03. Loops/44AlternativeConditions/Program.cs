namespace _44AlternativeConditions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int row = 1;
			int current = 1;
			while (current <= n)
			{
				for (int j = 1; j <= n/2 - row; j++)
				{
					Console.Write(" ");

				}
				for (int i = 1; i <= row; i++)
				{
					if (current <= n)
					{
						Console.Write(current + " ");
						current++;
					}
					else
					{
						break;
					}

				}
				row++;

				Console.WriteLine();
			}
		}
	}
}
