namespace _35ChristmasTree
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				Console.Write(" ");
			}
			Console.WriteLine(" |");

			for (int i = 1; i <= n; i++)
			{
				for (int j = n-i; j >= 1; j--)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.Write(" | ");

				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}

		}
	}
}
