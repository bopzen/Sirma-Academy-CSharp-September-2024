using System.Text.RegularExpressions;

namespace _15Letter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = Console.ReadLine().Split(", ");
            string pattern = @"[_]+";
            MatchCollection matches = Regex.Matches(text, pattern);

			for (int i = matches.Count - 1; i >= 0; i--)
			{
				Match match = matches[i];

				foreach (string word in words)
                {
                    if (word.Length == match.Length)
                    {
                        text = text.Substring(0, match.Index) + word + text.Substring(match.Index + match.Length);
                        break;
                    }
                }
            }
            Console.WriteLine(text);
		}
    }
}
