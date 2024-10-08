namespace _09GreaterOfTwoValues
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string valueType = Console.ReadLine();
			if (valueType == "int")
			{
				int a = int.Parse(Console.ReadLine());
				int b = int.Parse(Console.ReadLine());
				Console.WriteLine(GetMax(a, b));
			}
			else if (valueType == "char")
			{
				char a = char.Parse(Console.ReadLine());
				char b = char.Parse(Console.ReadLine());
				Console.WriteLine(GetMax(a, b));
			}
			else if (valueType == "string")
			{
				string a = Console.ReadLine();
				string b = Console.ReadLine();
				Console.WriteLine(GetMax(a, b));
			}


		}

		static int GetMax(int a, int b)
		{
			return a > b ? a : b;
		}

		static char GetMax(char a, char b)
		{
			return a > b ? a : b;
		}

		static string GetMax(string a, string b)
		{
			return a.CompareTo(b) >=0 ? a : b;
		}
	}
}
