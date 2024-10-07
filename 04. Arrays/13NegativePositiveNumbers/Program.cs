namespace _13NegativePositiveNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int frontIndex = 0;
            int backIndex = input.Length - 1;
            int[] result = new int[input.Length];
            for (int i = input.Length-1; i >=0; i--) 
            {
                if (input[i] >= 0)
                {
                    result[backIndex--] = input[i];
                }
                else
                {
                    result[frontIndex++] = input[i];
                }
            }
            Console.WriteLine(string.Join("\n", result));

        }
    }
}
