namespace _06CalculateRectangleArea
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());
			Console.WriteLine(CalculateRectangleArea(a, b));
		}

		static double CalculateRectangleArea(double a, double b)
		{
			return a * b;
		}
	}
}
