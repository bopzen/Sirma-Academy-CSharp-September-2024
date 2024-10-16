namespace _17MagicSquareChecker
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int m = size[0];
			int n = size[1];
			int[,] matrix = new int[m, n];

			for (int i = 0; i < m; i++)
			{
				int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
				for (int j = 0; j < n; j++)
				{
					matrix[i, j] = row[j];
				}
			}

			int sum = 0;
			bool isMagic = true;
			for (int j = 0; j < n; j++)
			{
				sum += matrix[0, j];
			}

			if (isMagic)
			{
				for (int j = 0; j < n; j++)
				{
					int currentSum = 0;
					for (int i = 0; i < m; i++)
					{
						currentSum += matrix[i, j];
					}
					if (currentSum != sum)
					{
						isMagic = false;
						break;
					}
				}
			}

			if (isMagic)
			{
				for (int i = 0; i < m; i++)
				{
					int currentSum = 0;
					for (int j = 0; j < n; j++)
					{
						currentSum += matrix[i, j];
					}
					if (currentSum != sum)
					{
						isMagic = false;
						break;
					}
				}
			}

			if (isMagic)
			{
				int currentSum = 0;
				for (int i = 0; i < m; i++)
				{
					currentSum += matrix[i, i];
				}
				if (currentSum != sum)
				{
					isMagic = false;
				}
			}

			if (isMagic)
			{
				int currentSum = 0;
				for (int i = 0; i < m; i++)
				{
					currentSum += matrix[i, n-1-i];
				}
				if (currentSum != sum)
				{
					isMagic = false;
				}
			}

			Console.WriteLine(isMagic);
		}
	}
}
