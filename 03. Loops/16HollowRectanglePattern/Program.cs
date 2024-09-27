namespace _16HollowRectanglePattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int m = int.Parse(Console.ReadLine());
			for (int row = 1; row <= n; row++) 
			{ 
				if (row == 1 || row == n)
				{
					for (int col = 1; col <= m; col++)
					{
						Console.Write("*");
					}
				}
				else
				{
					Console.Write("*");
					for (int col = 2; col <= m-1; col++)
					{
						Console.Write(" ");
					}
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
