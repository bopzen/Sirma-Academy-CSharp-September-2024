namespace _11MatrixBoundarySum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int m = size[0];
			int n = size[1];
			int[,] matrix = new int[m, n];
			int sum = 0;

			for (int i = 0; i < m; i++)
			{
				int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
				for (int j = 0; j < n; j++)
				{
					matrix[i, j] = row[j];
				}
			}

			for (int i = 0; i < m; i++)
			{
				sum += matrix[i, 0] + matrix[i, n-1];
			}
			for (int j = 1; j < n-1; j++)
			{
				sum += matrix[0, j] + matrix[m - 1, j];
			}
			
			Console.WriteLine(sum);
		}
	}
}
