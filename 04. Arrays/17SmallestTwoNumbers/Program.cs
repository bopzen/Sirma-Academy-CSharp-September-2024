namespace _17SmallestTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int minOne = array[0];
            int minTwo = array[0];

            foreach (int item in array)
            {
                if (item < minOne)
                {
                    minOne = item;
                }
            }
            foreach (int item in array)
            { 
                if (item < minTwo && item != minOne)
                {
                    minTwo = item ;
                } 
            }
            Console.WriteLine(minOne + " " + minTwo);
        }
    }
}
