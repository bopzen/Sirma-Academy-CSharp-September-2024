namespace _39ArrowPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n-1; i++)
			{
				for (int j = 1; j <= n-1-i; j++)
				{
					Console.Write(" ");
				}
				for (int j = 1;j <= i; j++)
				{
					Console.Write("* ");
				}
				Console.WriteLine();
			} 
			for(int i = 1; i <= n-1; i++)
			{
				for (int j = 1; j <= (n - 1) / 2; j++)
				{
					Console.Write(" ");
				}

				for (int j = 1; j <= n-1; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
