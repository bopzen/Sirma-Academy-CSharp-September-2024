namespace _05MaximumSumOf2X2Submatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int r = size[0];
            int c = size[1];
            int[,] matrix = new int[r, c];
            int maxSum = 0;
            int[,] submatrix = new int[2, 2];

            for (int i = 0; i < r; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = row[j];
                }
            }

            for (int i = 0;i < r-1; i++)
            {
                int sum = 0;
                for (int j = 0;j < c-1; j++)
                {
                    sum = matrix[i, j] + matrix[i+1, j] + matrix[i, j+1] + matrix[i+1, j+1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        submatrix[0, 0] = matrix[i, j];
                        submatrix[0, 1] = matrix[i, j + 1];
                        submatrix[1, 0] = matrix[i+1, j];                       
                        submatrix[1, 1] = matrix[i+1, j+1];
                    }
                }
            }
            Console.WriteLine(maxSum);
            Console.WriteLine(submatrix[0, 0] + " " + submatrix[0, 1]);
            Console.WriteLine(submatrix[1, 0] + " " + submatrix[1, 1]);
        }
    }
}
