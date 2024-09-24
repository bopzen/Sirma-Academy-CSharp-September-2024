namespace _18LeapYearChecker
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int year = int.Parse(Console.ReadLine());
			if ((year % 4 == 0 && year % 100 != 0) || (year % 100 == 0 && year % 400 == 0))
			{
				Console.WriteLine("It's a leap year!");
			}
			else
			{
				Console.WriteLine("It's not a leap year.");
			}
		}
	}
}
