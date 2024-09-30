namespace _22NumbersUpTo1000EndingIn7
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 1;
			while (number <= 1000)
			{
				if (number % 10 == 7)
				{
					Console.WriteLine(number);
				}
				number++;
			}
		}
	}
}
