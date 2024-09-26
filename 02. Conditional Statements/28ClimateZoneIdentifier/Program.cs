using System;

namespace _28ClimateZoneIdentifier
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double latitude = double.Parse(Console.ReadLine());

			if (Math.Abs(latitude) > 66.5)
			{
				Console.WriteLine("Arctic Zone");
			}
			else if (Math.Abs(latitude) >= 23.5)
			{
				Console.WriteLine("Temperate Zone");
			}
			else if (Math.Abs(latitude) > 0)
			{
				Console.WriteLine("Tropic Zone");
			}
			else if (latitude == 0)
			{
				Console.WriteLine("Equator");
			}
		}
	}
}
