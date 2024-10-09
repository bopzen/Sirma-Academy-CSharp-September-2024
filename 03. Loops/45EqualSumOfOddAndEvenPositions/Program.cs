namespace _45EqualSumOfOddAndEvenPositions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numberOne = int.Parse(Console.ReadLine());
			int numberTwo = int.Parse(Console.ReadLine());
			bool isFound = false;
			for (int i = numberOne; i <= numberTwo; i++)
			{
				string current = i.ToString();
				int sumOddIndex = 0;
				int sumEvenIndex = 0;
				for (int j = 0; j < current.Length; j++)
				{
					if (j % 2 == 0)
					{
						sumEvenIndex += int.Parse(current[j].ToString());
					}
                    else
                    {
                        sumOddIndex += int.Parse(current[j].ToString());
					}
                }
				if (sumOddIndex == sumEvenIndex)
				{
					if (!isFound)
					{
						isFound = true;
					}
					Console.WriteLine(current);
				}
			}
			if (!isFound)
			{
				Console.WriteLine("None");
			}
		}
	}
}
