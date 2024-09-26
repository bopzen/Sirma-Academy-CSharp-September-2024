using System;

namespace _29ArchitecturalEraIdentifier
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int year = int.Parse(Console.ReadLine());
			string material = Console.ReadLine();

			if (year < 500 && material == "stone")
			{
				Console.WriteLine("Ancient");
			}
			else if (500 <= year && year <= 1500 && material == "stone")
			{
				Console.WriteLine("Medieval");
			}
			else if (1500 <= year && year <= 1800 && material == "wood")
			{
				Console.WriteLine("Colonial");
			}
			else if (1800 <= year && year <= 1900 && material == "steel")
			{
				Console.WriteLine("Industrial");
			}
			else if (year > 1900 && material == "steel")
			{
				Console.WriteLine("Modern");
			}
			else
			{
				Console.WriteLine("Uncertain");
			}
		}
	}
}
