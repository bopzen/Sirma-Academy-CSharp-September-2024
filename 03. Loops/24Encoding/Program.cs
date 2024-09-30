namespace _24Encoding
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			while (number > 0)
			{
				int digit = number % 10;
				number /= 10;
				if (digit == 0)
				{
					Console.Write("ZERO");
				}
				else
				{
					for (int i = 0; i < digit; i++)
					{
						Console.Write(Convert.ToChar(digit + 33));
					}
				}
				
				Console.WriteLine();
			}
		}
	}
}
