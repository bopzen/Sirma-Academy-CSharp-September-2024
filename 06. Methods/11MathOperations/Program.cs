namespace _11MathOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double a = double.Parse(Console.ReadLine());
			string operation = Console.ReadLine();
			double b = double.Parse(Console.ReadLine());
			Console.WriteLine(Calculate(a, b, operation));
		}

		private static double Calculate(double a, double b, string operation)
		{
			if (operation == "+")
			{
				return a + b;
			}
			else if (operation == "-")
			{
				return a - b;
			}
			else if (operation == "*")
			{
				return a * b;
			}
			else if (operation == "/")
			{
				if (b != 0)
				{
					return a / b;
				}
				else {
					throw new Exception("Error, cannot divide by 0");
				}
				
			}
            else
            {
                 throw new Exception("Error, operation does not exist");
            }
        }
	}
}
