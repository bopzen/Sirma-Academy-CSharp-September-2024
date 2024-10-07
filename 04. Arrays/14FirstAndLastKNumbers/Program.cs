namespace _14FirstAndLastKNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int i = 0; i < k; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = array.Length-k; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            
        }
    }
}
