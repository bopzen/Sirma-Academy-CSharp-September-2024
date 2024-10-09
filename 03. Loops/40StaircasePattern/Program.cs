namespace _40StaircasePattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int k = 1;
			int m = 1;
			for (int i = 1; i <= n; i++)
			{
				if (i > 2)
				{
					for (int j = 1; j <= m; j++)
					{
						Console.Write(" ");
					}
					m += k+1;
					k++;
				}

				for (int j = 1; j <= i; j++)
				{
					Console.Write("#");
				}
				Console.WriteLine();
				
				
			}
			

		}
	}
}
