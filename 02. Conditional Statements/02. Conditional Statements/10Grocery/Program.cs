namespace _10Grocery
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string product = Console.ReadLine();
			string city = Console.ReadLine();
			double quantity = double.Parse(Console.ReadLine());

			double bill = 0;
			if (product == "tea")
			{
				if (city == "Sofia")
				{
					bill = quantity * 0.5;
				}
				else if (city == "Plovdiv")
				{
					bill = quantity * 0.4;
				}
				else if (city =="Varna")
				{
					bill = quantity * 0.45;
				}
			} 
			else if (product == "water")
			{
				if (city == "Sofia")
				{
					bill = quantity * 0.8;
				}
				else if (city == "Plovdiv")
				{
					bill = quantity * 0.7;
				}
				else if (city == "Varna")
				{
					bill = quantity * 0.7;
				}
			} 
			else if (product == "juice")
			{
				if (city == "Sofia")
				{
					bill = quantity * 1.2;
				}
				else if (city == "Plovdiv")
				{
					bill = quantity * 1.15;
				}
				else if (city == "Varna")
				{
					bill = quantity * 1.1;
				}
			}
			else if (product == "sweets")
			{
				if (city == "Sofia")
				{
					bill = quantity * 1.45;
				}
				else if (city == "Plovdiv")
				{
					bill = quantity * 1.3;
				}
				else if (city == "Varna")
				{
					bill = quantity * 1.35;
				}
			}
			else if (product == "chips")
			{
				if (city == "Sofia")
				{
					bill = quantity * 1.6;
				}
				else if (city == "Plovdiv")
				{
					bill = quantity * 1.5;
				}
				else if (city == "Varna")
				{
					bill = quantity * 1.55;
				}
			}

			Console.WriteLine($"{bill:F2}");
		}
	}
}
