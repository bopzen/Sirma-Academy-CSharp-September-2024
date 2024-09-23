namespace _19FuelEfficiency
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int distance = int.Parse(Console.ReadLine());
			int fuel = int.Parse(Console.ReadLine());
			double fuelEfficiency = (double)distance / fuel;
			Console.WriteLine($"{fuelEfficiency:F2}");
		}
	}
}
