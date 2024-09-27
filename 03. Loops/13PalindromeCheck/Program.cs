namespace _13PalindromeCheck
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string word = Console.ReadLine();
			string reversedWord = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
				reversedWord += word[i];
            }
			if (word.Equals(reversedWord))
			{
				Console.WriteLine("true");
			}
			else
			{
				Console.WriteLine("false");
			}
        }
	}
}
