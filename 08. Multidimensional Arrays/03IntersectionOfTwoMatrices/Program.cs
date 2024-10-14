namespace _03IntersectionOfTwoMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[,] A = new char[m, n];
            char[,] B = new char[m, n];
            char[,] C = new char[m, n];

            for (int i = 0; i < m; i++)
            {
                char[] row = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    A[i, j] = row[j];
                }
            }

            for (int i = 0; i < m; i++)
            {
                char[] row = Console.ReadLine().Split(" ").Select(char.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    B[i, j] = row[j];
                }
            }

            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i,j] ==  B[i,j])
                    {
                        C[i,j] = A[i,j];
                    }
                    else
                    {
                        C[i, j] = char.Parse("*");                     
                    }
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
