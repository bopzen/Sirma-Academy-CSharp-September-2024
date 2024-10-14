namespace _02MatrixAddition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int r = size[0];
            int c = size[1];
            int[,] matrixOne = new int[r, c];
            int[,] matrixTwo = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < c; j++)
                {
                    matrixOne[i, j] = row[j];
                }
            }

            for (int i = 0; i < r; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < c; j++)
                {
                    matrixTwo[i, j] = row[j];
                }
            }

            int[,] newMatrix = new int[r, c];
            for(int i = 0;i < r; i++)
            {
                for (int j = 0;j < c; j++)
                {
                    newMatrix[i,j] = matrixOne[i,j] + matrixTwo[i,j];
                }
            }

            for(int i = 0; i < r; i++)
            {
                for(int j = 0; j< c; j++)
                {
                    Console.Write(newMatrix[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
