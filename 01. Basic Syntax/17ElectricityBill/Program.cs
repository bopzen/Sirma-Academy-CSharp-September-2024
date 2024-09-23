namespace _17ElectricityBill
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int units = int.Parse(Console.ReadLine());
			double rate = double.Parse(Console.ReadLine());
			double totalBill = units * rate + 10;
			Console.WriteLine($"{totalBill:F2}");
		}
	}
}
