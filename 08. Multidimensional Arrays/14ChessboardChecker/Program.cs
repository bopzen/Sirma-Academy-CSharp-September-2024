namespace _14ChessboardChecker
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int m = size[0];
			int n = size[1];
			int[,] matrix = new int[m, n];
			List<int> queenRows = new List<int>();
			List<int> queenCols = new List<int>();

			for (int i = 0; i < m; i++)
			{
				int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
				for (int j = 0; j < n; j++)
				{
					matrix[i, j] = row[j];
					if (matrix[i,j] == 1)
					{
						queenRows.Add(i);
						queenCols.Add(j);
					}
				}
			}

			for (int i = 0; i < queenRows.Count; i++)
			{
				for (int j = i+1; j < queenCols.Count; j++)
				{
                    if (queenRows[i] == queenRows[j] ||       
						queenCols[i] == queenCols[j] ||       
						Math.Abs(queenRows[i] - queenRows[j]) == Math.Abs(queenCols[i] - queenCols[j]))
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
			}
            Console.WriteLine("No");
        }
	}
}
