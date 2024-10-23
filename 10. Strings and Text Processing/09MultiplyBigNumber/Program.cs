namespace _09MultiplyBigNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string numberOne = Console.ReadLine();
			string numberTwo = Console.ReadLine();
			string result = "";
			int excess = 0;
			for (int i = numberOne.Length - 1; i >= 0; i--)
			{
				int multiplication = int.Parse(numberOne[i].ToString()) * int.Parse(numberTwo) + excess;
				if (multiplication > 9)
				{
					int digit = multiplication % 10;
					result += digit;
					excess = multiplication / 10;
				}
				else
				{
					result += multiplication;
					excess = 0;
				}
			}
			if (excess > 0)
			{
				string finalExcess = excess.ToString();
				for (int i = finalExcess.Length - 1; i >= 0; i--)
				{
					result += finalExcess[i];
				}
			}
			
			for (int i = result.Length - 1; i >= 0; i--)
			{
				Console.Write(result[i]);
			}
		}
	}
}
