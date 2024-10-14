namespace _06PrintDiagonalsOfSquareMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++) 
                {          
                    matrix[i,j] = row[j];
                }
            }

            for (int i = 0; i < n; i++) 
            {
                Console.Write(matrix[i, i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write(matrix[n-1-i, i] + " ");
            }

        }
    }
}
