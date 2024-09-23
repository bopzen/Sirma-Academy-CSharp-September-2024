namespace _18Average_Speed
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int distance = int.Parse(Console.ReadLine());
			int time = int.Parse(Console.ReadLine());
			double averageSpeed = (double)distance / time;
			Console.WriteLine($"{averageSpeed:F2}");
		}
	}
}
