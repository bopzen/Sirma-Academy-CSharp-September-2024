using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace _26EvenPairs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int firstPairStart = int.Parse(Console.ReadLine());
			int secondPairStart = int.Parse(Console.ReadLine());
			int firstPairDiff = int.Parse(Console.ReadLine());
			int secondPairDiff = int.Parse(Console.ReadLine());

			for (int i = firstPairStart; i <= firstPairStart + firstPairDiff; i++)
			{
				for (int j = secondPairStart; j <= secondPairStart + secondPairDiff; j++)
				{
					if (CheckIfPrime(i) && CheckIfPrime(j)) 
					{
						Console.WriteLine($"{i}{j}");
					}		
				}
			}


		}

		public static bool CheckIfPrime(int number)
		{
			if (number <=3)
			{
				return true;
			}
			for (int i = 2; i < number-1 ; i++)
			{
				if (number % i == 0)
				{
					return false;
				}
			}
			return true;
		}
	}
}
