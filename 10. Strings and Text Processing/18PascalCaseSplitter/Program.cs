using System.Text.RegularExpressions;

namespace _18PascalCaseSplitter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"[A-Z]{1}[a-z]+";
			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(input);
			Console.WriteLine(string.Join(", ", matches));
		}
	}
}
