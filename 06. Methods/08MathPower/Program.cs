namespace _08MathPower
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double number = double.Parse(Console.ReadLine());
			int power = int.Parse(Console.ReadLine());
			Console.WriteLine(MathPower(number, power));
		}

		static double MathPower(double number, int power)
		{
			double result = number;
			for (int i = 1; i < power; i++)
			{
				result *= number;
			}
			return result;
		}
	}
}
