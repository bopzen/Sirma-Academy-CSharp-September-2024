using System.Text;

namespace _04SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int r = size[0];
            int c = size[1];
            int[,] matrix = new int[r, c];
            int sum = 0;

            for (int i = 0; i < r; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = row[j];
                    sum += matrix[i, j];
                }
            }
            Console.WriteLine(r);
            Console.WriteLine(c);
            Console.WriteLine(sum);
        }
    }
}
