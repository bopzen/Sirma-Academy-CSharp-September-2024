namespace _37HousePattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i+=2) 
			{ 
				for (int j = 1; j <= (n - i)/2; j++)
				{
					Console.Write(" ");
				}
				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			Console.Write("*");
			for (int i = 1; i <=n-2; i++)
			{
				Console.Write(" ");
			}
			Console.WriteLine("*");
			Console.Write("*");
			for (int i = 1; i <= n - 2; i++)
			{
				Console.Write(" ");
			}
			Console.WriteLine("*");
		}
	}
}
