namespace _10Time
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int minutes = int.Parse(Console.ReadLine());
			int hh = minutes / 60;
			int mm = minutes % 60;
			Console.WriteLine($"{hh:D2}:{mm:D2}");
		}
	}
}
