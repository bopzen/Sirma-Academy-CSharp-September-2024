namespace _07EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(",").Select(x => int.Parse(x)).ToArray();
            bool areIdentical = true;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    areIdentical = false;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index.");
                    break;
                }
            }
            if (areIdentical) 
            {
                int sum = 0;
                foreach (int i in arrayOne)
                {
                    sum += i;
                }
                Console.WriteLine($"Arrays are identical. Sum: { sum}");
            }
        }
    }
}
