namespace _18SpiralMatrixTraversal
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int m = size[0];
			int n = size[1];
			int[,] matrix = new int[m, n];
			List<int> spiral = new List<int>();

			for (int i = 0; i < m; i++)
			{
				int[] r = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
				for (int j = 0; j < n; j++)
				{
					matrix[i, j] = r[j];
				}
			}

			int offset = 0;
			int row = 0;
			int col = 0;
			for (int count = 0; count < m * n; count++)
			{
                for (col = 0 + offset; col < n - offset; col++)
                {
					spiral.Add(matrix[0 + offset, col]);
                }
				for (row = 1 + offset; row < m - offset; row++)
				{
                    spiral.Add(matrix[row, n-1-offset]);
                }
				for (col = n - offset -2; col >= 0 + offset; col--)
				{
                    spiral.Add(matrix[m-offset-1, col]);
                }
				for (row = m - offset -2 ; row >= 1 + offset; row--)
				{
                    spiral.Add(matrix[row, 0 + offset]);
                }
				offset++;
            }
			Console.WriteLine(string.Join(" ", spiral));
		}
	}
}
