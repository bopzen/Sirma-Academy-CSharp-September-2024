using System;

namespace _20DaysInAMonth
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int month = int.Parse(Console.ReadLine());
			if (month == 4 || month == 6 || month == 9 || month == 11)
			{
				Console.WriteLine("30");

			}
			else if (month == 2)
			{
				Console.WriteLine("28");

			}
			else
			{
				Console.WriteLine("31");

			}
		}
	}
}
