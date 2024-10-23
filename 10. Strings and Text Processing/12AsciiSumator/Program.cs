namespace _12AsciiSumator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			char charOne = char.Parse(Console.ReadLine());
			char charTwo = char.Parse(Console.ReadLine());
			int indexOne = (int)charOne;
			int indexTwo = (int)charTwo;
			string text = Console.ReadLine();
			int asciiSum = 0;

			foreach (var symbol in text)
			{
				if ((int)symbol > Math.Min(indexOne, indexTwo) && (int)symbol < Math.Max(indexOne, indexTwo))
				{
					asciiSum += (int)symbol;
				}
			}
			Console.WriteLine(asciiSum);
		}
	}
}
