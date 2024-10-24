using System.Text.RegularExpressions;

namespace _19MatchDates
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"(?<Day>\d{2})([.\-\/]{1})(?<Month>[A-z]{1}[a-z]{2})\2(?<Year>\d{4})";
			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(input);
			Console.WriteLine(string.Join(", ", matches));
		}
	}
}
