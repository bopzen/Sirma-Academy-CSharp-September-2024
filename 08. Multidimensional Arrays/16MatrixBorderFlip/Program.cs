namespace _16MatrixBorderFlip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int m = size[0];
            int n = size[1];
            int[,] matrix = new int[m, n];
            List<int> borderElements = new List<int>();

            for (int i = 0; i < m; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            for (int c = 0; c < n; c++)
            {
                borderElements.Add(matrix[0, c]);
            }

            for (int r = 1; r < m; r++)
            {
				borderElements.Add(matrix[r, n-1]); 
			}

			for (int c = n-2; c >= 0; c--)
			{
				borderElements.Add(matrix[m-1, c]);
			}

			for (int r = m-2; r >= 1; r--)
			{
				borderElements.Add(matrix[r, 0]);
			}


            int lastElement = borderElements[borderElements.Count-1];
            borderElements.RemoveAt(borderElements.Count - 1);
            borderElements.Insert(0, lastElement);

			int counter = 0;
			for (int c = 0; c < n; c++)
			{
				matrix[0, c] = borderElements[counter++];
			}

			for (int r = 1; r < m; r++)
			{
				matrix[r, n - 1] = borderElements[counter++];
			}

			for (int c = n - 2; c >= 0; c--)
			{
				matrix[m - 1, c] = borderElements[counter++];
			}

			for (int r = m - 2; r >= 1; r--)
			{
				matrix[r, 0] = borderElements[counter++];
			}


			for (int i = 0; i < m; i++)
			{

				for (int j = 0; j < n; j++)
				{
                    Console.Write(matrix[i, j] + " ");
				}
                Console.WriteLine();
			}
		}
    }
}
