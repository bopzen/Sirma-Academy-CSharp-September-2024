namespace _10ZeroMatrix
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int m = size[0];
			int n = size[1];
			int[,] matrix = new int[m, n];
			bool[] zeroRows = new bool[m];
			bool[] zeroCols = new bool[n];

			for (int i = 0; i < m; i++)
			{
				int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
				for (int j = 0; j < n; j++)
				{
					matrix[i, j] = row[j];
					if (matrix[i,j] == 0)
					{
						zeroRows[i] = true;
						zeroCols[j] = true;
					}
				}
			}

			for (int i = 0; i < m; i++)
			{
				if (zeroRows[i])
				{
					for (int j = 0;j < n; j++)
					{
						matrix[i, j] = 0;
					}
				}
			}

			for (int j = 0; j < n; j++)
			{
				if (zeroCols[j])
				{
					for (int i = 0; i < m; i++)
					{
						matrix[i, j] = 0;
					}
				}
			}


			for (int i = 0;i < m; i++)
			{
				for (int j = 0;j < n; j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}

		}
	}
}
