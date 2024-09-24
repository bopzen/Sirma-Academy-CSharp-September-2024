namespace _07Speed
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int speed = int.Parse(Console.ReadLine());
			if (speed <= 10 )
			{
				Console.WriteLine("slow");
			} else if (speed <= 60 )
			{
				Console.WriteLine("aveage");
			} else if (speed <= 120)
			{
				Console.WriteLine("fast");
			} else if (speed <= 160)
			{
				Console.WriteLine("super-fast");
			} else
			{
				Console.WriteLine("turbo-fast");
			}
		}
	}
}
