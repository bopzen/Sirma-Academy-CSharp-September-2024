namespace _06RandomizeWords
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] words = Console.ReadLine().Split(" ");
			Random rnd = new Random();
			for (int i = 0; i < words.Length; i++)
			{
				int newIndex = rnd.Next(i, words.Length);
				string temp = words[i];
				words[i] = words[newIndex];
				words[newIndex] = temp;
			}

			Console.WriteLine(string.Join("\n", words));
		}
	}
}
