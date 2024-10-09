namespace _41HourglassPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n+2; i++)
			{
				Console.Write("#");
			}
			Console.WriteLine();

			for (int i = 1; i < (n+2)/2; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(" ");
				}
				for (int j = i+1; j <= n+2-i; j++)
				{
					if (j == i+1 || j == n+2-i) 
					{ 
						Console.Write("#"); 
					}
					else
					{
						Console.Write(" ");
					}				
				}
				Console.WriteLine();
			}


			if (n % 2 != 0)
			{
				for (int i = 1; i <= (n + 2) / 2; i++)
				{
					Console.Write(" ");
				}
				Console.WriteLine("#");
			}

			for (int i = (n+2)/2-1; i >= 1; i--)
			{
				if ((n % 2 == 0) && (i == (n + 2) / 2 - 1))
				{
					continue;
				}
				for (int j = 1; j <= i; j++)
				{
					Console.Write(" ");
				}
				for (int j = i+1; j <= n+2-i; j++)
				{
					if (j == i+1 || j == n+2-i) 
					{ 
						Console.Write("#"); 
					}
					else
					{
						Console.Write(" ");
					}				
				}
				Console.WriteLine();
			}
			
			for (int i = 1; i <= n + 2; i++)
			{
				Console.Write("#");
			}
		}
	}
}
