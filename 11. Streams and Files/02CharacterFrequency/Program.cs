namespace _02CharacterFrequency
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"..\..\..\input.txt";
			Dictionary<char, int> frequency = new Dictionary<char, int>();

			using (StreamReader reader = new StreamReader(filePath))
			{
				int symbol;
				while((symbol = reader.Read()) != -1)
				{
					if (!frequency.ContainsKey((char)symbol))
					{
						frequency[(char)symbol] = 0;
					}
					frequency[(char)symbol]++;
				}
			}

			foreach (var kvp in frequency)
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value}");
			}
		}
	}
}
