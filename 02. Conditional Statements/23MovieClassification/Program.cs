namespace _23MovieClassification
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int age = int.Parse(Console.ReadLine());
			if (age > 0 && age < 13)
			{
				Console.WriteLine("U-rated movies");
			}
			else if (age <=17)
			{
				Console.WriteLine("U and PG-13 rated movies");
			}
			else
			{
				Console.WriteLine("All movies");
			}
		}
	}
}
