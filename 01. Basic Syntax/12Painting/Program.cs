namespace _12Painting
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double n = int.Parse(Console.ReadLine());
			double yellow = 4 * n / 13;
			double red = yellow / 4;
			double white = yellow * 2;
			Console.WriteLine($"Red: {red:F4}");
			Console.WriteLine($"Yellow: {yellow:F4}");
			Console.WriteLine($"White: {white:F4}");
		}
	}
}
