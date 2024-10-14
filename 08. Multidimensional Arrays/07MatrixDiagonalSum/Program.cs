namespace _07MatrixDiagonalSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int m = size[0];
            int n = size[1];
            int[,] matrix = new int[m, n];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }
            for (int i = 0; i < n; i++)
            {
                sum += matrix[n - 1 - i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
