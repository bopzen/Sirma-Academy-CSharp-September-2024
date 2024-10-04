namespace _03ReverseAnArrayOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
            int[] newArray = new int[n];
            int index = 0;
            for (int i = n-1; i >= 0; i--)
            {
                newArray[index++] = array[i];
            }
            foreach (var item in newArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
