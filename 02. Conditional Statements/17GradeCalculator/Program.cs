namespace _17GradeCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int percentage = int.Parse(Console.ReadLine());
			if (90 <= percentage && percentage <=100 ) 
			{
				Console.WriteLine("A");
			}
			else if (80 <= percentage && percentage <= 89)
			{
				Console.WriteLine("B");
			}
			else if (70 <= percentage && percentage <= 79)
			{
				Console.WriteLine("C");
			}
			else if (60 <= percentage && percentage <= 69)
			{
				Console.WriteLine("D");
			}
			else if (0 <= percentage && percentage <= 59)
			{
				Console.WriteLine("F");
			}
			else
			{
				Console.WriteLine("else");
			}
		}
	}
}
