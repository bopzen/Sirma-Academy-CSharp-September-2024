namespace _11Speed
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int meters = int.Parse(Console.ReadLine());
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			int seconds = int.Parse(Console.ReadLine());
			int time = hours * 60 * 60 + minutes * 60 + seconds;
			double speed = (double)meters / time;
			Console.WriteLine($"{speed:F6}");
		}
	}
}
