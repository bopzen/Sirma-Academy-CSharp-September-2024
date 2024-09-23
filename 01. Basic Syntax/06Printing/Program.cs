namespace _06Printing
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			char symbol = char.Parse(Console.ReadLine());
			int integer = int.Parse(Console.ReadLine());
			double real = double.Parse(Console.ReadLine());
			Console.WriteLine(text);
			Console.WriteLine(symbol);
			Console.WriteLine(integer);
			Console.WriteLine(real);
			Console.Write(text);
			Console.Write(symbol);
			Console.Write(integer);
			Console.Write(real);
		}
	}
}
