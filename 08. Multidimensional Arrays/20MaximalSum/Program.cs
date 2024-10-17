namespace _20MaximalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int m = size[0];
            int n = size[1];
            int[,] matrix = new int[m, n];
            int[,] maxMatrix = new int[3, 3];
            
            int maxSum = 0;

            for (int i = 0; i < m; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

			for (int i = 0; i < m - 2; i++)
			{
				
				for (int j = 0; j < n - 2; j++)
				{
					int sum = 0;
					int[,] subMatrix = new int[3, 3];
					for (int k = i; k <= i+2; k++) 
                    { 
                        for(int k2 = j; k2 <= j+2; k2++)
                        {
							subMatrix[k-i, k2-j] = matrix[k, k2];
                            sum += matrix[k, k2];

						}
                    }
					if (sum > maxSum)
					{
						maxSum = sum;
						for (int k = 0; k < 3; k++)
                        {
                            for (int k2 = 0; k2 < 3; k2++)
                            {
                                maxMatrix[k, k2] = subMatrix[k, k2];
                            }
                        }
					}
				}
			}
            Console.WriteLine("Sum = " + maxSum);
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(maxMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

		}
    }
}
