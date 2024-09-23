namespace _14Journey
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int speedX = int.Parse(Console.ReadLine());
			int speedY = int.Parse(Console.ReadLine());

			int distanceX = speedX * 5;
			int distanceY = speedY * 3;

			Console.WriteLine(Math.Abs(distanceX - distanceY));
		}
	}
}
