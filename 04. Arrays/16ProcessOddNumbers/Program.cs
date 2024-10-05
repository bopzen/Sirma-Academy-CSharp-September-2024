namespace _16ProcessOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int i = array.Length-1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    Console.Write(array[i] * 2 + " ");
                }
            }

        }
    }
}
