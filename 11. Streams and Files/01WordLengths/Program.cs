namespace _01WordLengths
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"..\..\..\input.txt";
			List<string> words = new List<string>();

			using (StreamReader reader = new StreamReader(filePath))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					words.AddRange(line.Split(" "));
				}
			}

			Console.WriteLine(string.Join(", ", words.Select(w => w.Length)));
		}
	}
}
