﻿namespace _19MovieTicketPrice
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int age = int.Parse(Console.ReadLine());
			if (age >= 0 && age <=12 )
			{
				Console.WriteLine("$5");
			}
			else if (age >= 13 && age <= 19)
			{
				Console.WriteLine("$8");
			}
			else if (age >= 20)
			{
				Console.WriteLine("$10");
			}
			else
			{
				Console.WriteLine("error");
			}
		}
	}
}
