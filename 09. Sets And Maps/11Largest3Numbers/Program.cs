namespace _11Largest3Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[] topThree = numbers.OrderDescending().Take(3).ToArray();
            Console.WriteLine(string.Join(" ", topThree));
        }
    }
}
