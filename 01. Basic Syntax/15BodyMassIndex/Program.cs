namespace _15BodyMassIndex
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double weight = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());
			double bmi = weight / Math.Pow(height, 2);
			Console.WriteLine($"{bmi:F2}");
		}
	}
}
