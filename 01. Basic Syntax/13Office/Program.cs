namespace _13Office
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double costFirst = double.Parse(Console.ReadLine());
			double costSecond = costFirst - costFirst * 0.2;
			double costThird = (costFirst + costSecond) * 1.15;
			Console.WriteLine($"{(costFirst + costSecond + costThird):F3}");
		}
	}
}
