namespace _07WeatherForecast
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter city: ");
			string city = Console.ReadLine();
			Console.Write("Enter temperature: ");
			int degrees = int.Parse(Console.ReadLine());
			Console.WriteLine($"Today in {city} it is {degrees} degrees.");

		}
	}
}
