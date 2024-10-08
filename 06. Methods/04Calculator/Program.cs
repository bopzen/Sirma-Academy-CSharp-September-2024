namespace _04Calculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string operation = Console.ReadLine();
			double a = double.Parse(Console.ReadLine());
			double b = double.Parse(Console.ReadLine());

			if (operation == "add")
			{
				Add(a, b);
			}
			else if (operation == "multiply")
			{
				Multiply(a, b);
			}
			else if (operation == "subtract")
			{
				Subtract(a, b);
			}
			else if (operation == "divide")
			{
				Divide(a, b);
			}
		}

		static void Add(double a, double b)
		{
			Console.WriteLine(a + b);
		}
		static void Multiply(double a, double b)
		{
			Console.WriteLine(a * b);
		}
		static void Subtract(double a, double b)
		{
			Console.WriteLine((a - b));
		}
		static void Divide(double a, double b)
		{
			if (b != 0)
			{
				Console.WriteLine(a / b);
			}
			else
			{
				Console.WriteLine("Error, cannot divide by 0");
			}

		}
	}
}
