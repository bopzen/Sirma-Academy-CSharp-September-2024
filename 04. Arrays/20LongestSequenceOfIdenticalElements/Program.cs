namespace _20LongestSequenceOfIdenticalElements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int counter = 1;
			int number = array[0];
			int maxCounter = 0;
			int maxNumber = 0;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] == number)
				{
					counter++;
				}
				else
				{
					if (maxCounter < counter)
					{
						maxCounter = counter;
						maxNumber = number;
						number = array[i];
						counter = 1;
					}
				}
			}
			if (maxCounter == 0)
			{
				for (int i = 0; i < counter; i++)
				{
					Console.Write(number + " ");
				}
			}
			else
			{
				for (int i = 0; i < maxCounter; i++)
				{
					Console.Write(maxNumber + " ");
				}
			}

		}
	}
}
