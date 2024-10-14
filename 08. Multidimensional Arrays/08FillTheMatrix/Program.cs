namespace _08FillTheMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int n = int.Parse(input[0]);
            string pattern = input[1];
            PrintMatrixByPattern(n, pattern);         
        }

        public static void PrintMatrixByPattern(int n, string pattern)
        {
            int[,] matrix = new int[n, n];
            int number = 1;
            if (pattern == "A")
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[j, i] = number++;
                    }
                }
            }
            else if (pattern == "B") 
            {
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 != 0)
                    {
                        for (int j = n-1; j >= 0; j--)
                        {
                            matrix[j, i] = number++;
                        }
                    }
                    else
                    {
                        for (int j = 0; j < n; j++)
                        {
                            matrix[j, i] = number++;
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
