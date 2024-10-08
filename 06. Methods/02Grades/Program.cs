namespace _02Grades
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double grade = double.Parse(Console.ReadLine());
			PrintGrade(grade);
		}

		static void PrintGrade(double grade)
		{
			if (grade >= 2.00 && grade < 3)
			{
				Console.WriteLine("Frail");
			}
			else if (grade < 3.50)
			{
				Console.WriteLine("Poor");
			}
			else if (grade < 4.50)
			{
				Console.WriteLine("Good");
			}
			else if (grade < 5.50)
			{
				Console.WriteLine("Very good");
			}
			else if (grade <= 6.00)
			{
				Console.WriteLine("Excellent");
			}
            else
            {
				Console.WriteLine("Wrong grade. It must be between 2 and 6");
            }
        }
	}
}
