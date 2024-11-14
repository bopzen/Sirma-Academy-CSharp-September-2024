using System.Text;
using System.Text.RegularExpressions;

namespace _07CountUniqueWords
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"..\..\..\input.txt";

			HashSet<string> uniqueWords = new HashSet<string>();

			using (StreamReader reader = new StreamReader(filePath))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					string result = Regex.Replace(line, "[^a-zA-Z0-9 ]", "");
					uniqueWords.UnionWith(result.Split(" "));
				}
			}
			Console.WriteLine(uniqueWords.Count);
		}
	}
}
