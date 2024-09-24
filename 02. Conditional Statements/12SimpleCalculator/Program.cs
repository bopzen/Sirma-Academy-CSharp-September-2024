namespace _12SimpleCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double numOne = double.Parse(Console.ReadLine());
			double numTwo = double.Parse(Console.ReadLine());
			string operation = Console.ReadLine();

			switch (operation)
			{
				case "add":
					Console.WriteLine($"{(numOne + numTwo):F2}");
					break;
				case "subtract":
					Console.WriteLine($"{(numOne - numTwo):F2}");
					break;
				case "multiply":
					Console.WriteLine($"{(numOne * numTwo):F2}");
					break;
				case "divide":
					if (numTwo != 0.0)
					{
						Console.WriteLine($"{(numOne / numTwo):F2}");
					}
					else
					{
						Console.WriteLine("Cannot divide by zero");
					}
					break;
				default:
					Console.WriteLine("Invalid operation");
					break;
			}
		}
	}
}
