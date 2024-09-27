namespace _15CollatzConjecture
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			while (n != 1)
			{
				Console.Write(n + " ");
				if (n % 2 == 0)
				{
					n /= 2;
				}
				else
				{
					n = n * 3 + 1;
				}
			}
			Console.Write(n);
		}
	}
}
