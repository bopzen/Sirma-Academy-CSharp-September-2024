namespace _09SumOfEvenNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			int i = 1;
			int number = 1;

			while (i <= n)
			{
				if (number % 2 == 0)
				{
					sum += number;
					i++;
				}
				number++;
			}
			Console.WriteLine(sum);
		}
	}
}
