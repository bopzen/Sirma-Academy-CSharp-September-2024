namespace _11ExtractPersonInformation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				Console.WriteLine($"{ExtractString(input, '@', '|')} is {ExtractString(input, '#', '*')} years old."); 
			}
		}

		public static string ExtractString(string text, char a, char b)
		{
			int startIndex = text.IndexOf(a);
			int endIndex = text.IndexOf(b);
			string result = text.Substring(startIndex + 1, endIndex - startIndex -1);
			return result;
		}
	}
}
