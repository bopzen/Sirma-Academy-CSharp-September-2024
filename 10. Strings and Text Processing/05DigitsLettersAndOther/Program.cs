namespace _05DigitsLettersAndOther
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string digits = "";
			string letters = "";
			string other = "";
			foreach (var symbol in input)
			{
				if (char.IsDigit(symbol))
				{
					digits += symbol;
				}
				else if (char.IsLetter(symbol))
				{
					letters += symbol;
				}
				else
				{
					other += symbol;
				}
			}

			Console.WriteLine(digits);
			Console.WriteLine(letters);
			Console.WriteLine(other);
		}
	}
}
