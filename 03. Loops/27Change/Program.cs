namespace _27Change
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double change = double.Parse(Console.ReadLine());
			int count = 0;

			int amount = (int)(change * 100);

			while (amount > 0)
			{
				if (amount >= 200)
				{
					count += amount / 200;
					amount %= 200;
				}
				else if (amount >= 100)
				{
					count += amount / 100;
					amount %= 100;
				}
                else if (amount >= 50)
                {
					count += amount / 50;
					amount %= 50;
				}
				else if (amount >= 20)
				{
					count += amount / 20;
					amount %= 20;
				}
				else if (amount >= 10)
				{
					count += amount / 10;
					amount %= 10;
				}
				else if (amount >= 5)
				{
					count += amount / 5;
					amount %= 5;
				}
				else if (amount >= 2)
				{
					count += amount / 2;
					amount %= 2;
				}
				else if (amount >= 1)
				{
					count += amount / 1;
					amount %= 1;
				}
			}
			Console.WriteLine(count);
		}
	}
}
