using System.Text.RegularExpressions;

namespace _06ValidUsernames
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] input = Console.ReadLine().Split(", ");
			string pattern = @"^[a-zA-Z0-9_-]{3,16}$";
			Regex regex = new Regex(pattern);

			foreach (string line in input)
			{
				Match match = regex.Match(line);
				if (match.Success)
				{
					Console.WriteLine(line);
				}
			}
		}
	}
}
