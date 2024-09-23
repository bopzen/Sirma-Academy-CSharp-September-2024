namespace _16WaterConsumption
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double weeklyConsumption = double.Parse(Console.ReadLine());
			int people = int.Parse(Console.ReadLine());
			double dailyConsumption = weeklyConsumption / people / 7;
			Console.WriteLine($"{dailyConsumption:F2}");
		}
	}
}
