using System.Text.RegularExpressions;

namespace _17MatchPhoneNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"\+359([ -])\d{1}\1\d{3}\1\d{4}\b";
			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(input);

			Console.WriteLine(string.Join(", ", matches));
		}
	}
}
