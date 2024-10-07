namespace _15LastKNumbersSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] result = new int[n];
            result[0] = 1;
            for (int i = 1; i < n; i++)
            {
                int sum = 0;
                for (int j = i-1; j >= Math.Max(i-k,0); j--)
                {
                    sum += result[j];
                }
                result[i] = sum;    
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
