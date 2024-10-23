namespace _04TextFilter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] banList = Console.ReadLine().Split(", ");
			string text = Console.ReadLine();
			foreach (string bannedWord in banList)
			{
				while (text.Contains(bannedWord))
				{
					string censoredWord = "";
					for (int i = 0; i < bannedWord.Length; i++)
					{
						censoredWord += "*";
					}
					text = text.Replace(bannedWord, censoredWord);
				}
			}
			Console.WriteLine(text);
		}
	}
}
