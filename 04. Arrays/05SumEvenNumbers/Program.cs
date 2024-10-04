namespace _05SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
            int sum = 0;
            foreach (int item in arr)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
