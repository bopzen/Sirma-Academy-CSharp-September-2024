using System.Text.RegularExpressions;

namespace _16MatchFullName
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string pattern = @"\b[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+\b";
			Regex regex = new Regex(pattern);
			MatchCollection matches = regex.Matches(input);
			foreach (Match match in matches)
			{
				Console.Write(match.ToString() + " ");
			}
		}
	}
}
