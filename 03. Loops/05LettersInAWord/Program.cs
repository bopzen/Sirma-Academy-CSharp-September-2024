namespace _05LettersInAWord
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			foreach (var letter in text)
			{
				Console.WriteLine(letter);
			}
		}
	}
}
