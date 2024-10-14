namespace _09RowSumAndColumnSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int m = size[0];
            int n = size[1];
            int[,] matrix = new int[m, n];
            int[] rowSums = new int[m];
            int[] columnSums = new int[n];

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
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i, j];
                }
                rowSums[i] = sum;
            }
            Console.WriteLine($"Row Sums: {string.Join(", ", rowSums)}");

            for (int i = 0; i < n; i++)
            {
                int sum = 0;
                for (int j = 0; j < m; j++)
                {
                    sum += matrix[j, i];
                }
                columnSums[i] = sum;
            }
            Console.WriteLine($"Column Sums: {string.Join(", ", columnSums)}");
        }
    }
}
