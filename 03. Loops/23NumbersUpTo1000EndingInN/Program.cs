namespace _23NumbersUpTo1000EndingInN
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = 1;
			int n = int.Parse(Console.ReadLine());
			while (number <= 1000)
			{
				if (number % 10 == n)
				{
					Console.WriteLine(number);
				}
				number++;
			}
		}
	}
}
