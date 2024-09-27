namespace _14ArmstrongNumberCheck
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int sum = 0;
			int number = n;
			int digits = n.ToString().Length;
			while (n > 0)
			{
				int digit = n % 10;
				sum += (int)Math.Pow(digit, digits);
				n /= 10;
			}
			if (number == sum)
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
