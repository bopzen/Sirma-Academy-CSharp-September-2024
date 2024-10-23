namespace _10ReplaceRepeatingChars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			char character = ' ';
			string result = "";
			foreach (var symbol in input)
			{
				if (symbol == character)
				{
					continue;
				}
				else
				{
					result += symbol;
					character = symbol;
				}
			}
			Console.WriteLine(result);
		}
	}
}
