namespace _21Snowflakes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
			int m = size[0];
			int n = size[1];
			string[,] matrix = new string[m, n];
			int[] snowflakeIndex = new int[n];
			bool hasFallen = true;

			for (int i = 0; i < m; i++)
			{
				string[] r = Console.ReadLine().Split(" ");
				for (int j = 0; j < n; j++)
				{
					matrix[i, j] = r[j];
				}
			}
			while (hasFallen)
			{
				hasFallen = false;

				string[,] newMatrix = new string[m, n];
				for (int i = 0; i < m; i++)
				{
					for (int j = 0; j < n; j++)
					{
						newMatrix[i, j] = matrix[i, j];
					}
				}

				for (int i = 0; i < m-1; i++)
				{
					for (int j = 0; j < n; j++)
					{
						if (matrix[i, j] == "*")
						{
							if (matrix[i+1, j] == "0")
							{
								newMatrix[i, j] = "0";
								newMatrix[i + 1, j] = "*";
								hasFallen = true;
							}
						}
					}
				}
				matrix = newMatrix;

				

				if (hasFallen)
				{
					for (int i = 0; i < m; i++)
					{
						for (int j = 0; j < n; j++)
						{
							Console.Write(matrix[i, j] + " ");
						}
						Console.WriteLine();
					}
					Console.WriteLine("===");
				}
			}
		}
	}
}
