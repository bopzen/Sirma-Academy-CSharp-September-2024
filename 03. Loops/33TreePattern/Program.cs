namespace _33TreePattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int r = 1; r <= n; r++)
			{
				for (int c = 1; c <= n - r; c++)
				{
					Console.Write(" ");
				}
				for (int c = 1; c <= 2 * r - 1; c++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			for (int c = 1; c <= n - 1; c++)
			{
				Console.Write(" ");
			}
			Console.WriteLine("*");
		}
	}
}
