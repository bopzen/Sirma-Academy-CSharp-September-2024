namespace _01CompareMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isEqual = true;

            int[] dimensionsOne = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rOne = dimensionsOne[0];
            int cOne = dimensionsOne[1];
            int[,] matrixOne = new int[rOne, cOne];
            for (int i = 0; i < rOne; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < cOne; j++)
                {
                    {
                        matrixOne[i, j] = row[j];
                    }
                }
            }

            int[] dimensionsTwo = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int rTwo = dimensionsTwo[0];
            int cTwo = dimensionsTwo[1];
            int[,] matrixTwo = new int[rTwo, cTwo];
            for (int i = 0; i < rTwo; i++)
            {
                int[] row = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int j = 0; j < cTwo; j++)
                {
                    {
                        matrixTwo[i, j] = row[j];
                    }
                }
            }

            if (rOne != rTwo || cOne != cTwo)
            {
                isEqual = false;
            }
            else
            {
                for (int i = 0; i < rOne; i++)
                {
                    for (int j = 0; j < cOne; j++)
                    {
                        if (matrixOne[i, j] != matrixTwo[i, j])
                        {
                            isEqual = false;
                            break;
                        }
                    }
                }
            }

            if (isEqual)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
    }
}
