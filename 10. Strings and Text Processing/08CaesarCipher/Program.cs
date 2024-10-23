namespace _08CaesarCipher
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			foreach (var symbol in input)
			{
				char newSymbol = (char)(symbol + 3);
				Console.Write(newSymbol);
			}
		}
	}
}
