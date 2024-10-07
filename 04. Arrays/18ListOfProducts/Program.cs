using System.Collections.Immutable;

namespace _18ListOfProducts
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] products = Console.ReadLine().Split(", ");
			Array.Sort(products);
			for (int i = 0; i < products.Length; i++)
			{
				Console.WriteLine($"{i+1}.{products[i]}");
			}
		}
	}
}
