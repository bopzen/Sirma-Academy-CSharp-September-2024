namespace _19CheckerboardPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = num;
                    if (num == 0)
                    {
                        if (j == n-1 && n % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            num = 1;
                        }
                        
                    }
                    else if (num == 1)
                    {
                        if (j == n - 1 && n % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            num = 0;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
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
