namespace _12ExtractANon_DecreasingSubsequenceFromAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int maxNumber = 0;
            foreach (int number in numbers)
            {
                if (number >= maxNumber)
                {
                    Console.Write(number + " ");
                    maxNumber = number;
                }
            }

        }
    }
}
