namespace _20SetsOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int n = input[0];
            int m = input[1];
            HashSet<int> setOne = new HashSet<int>();
            HashSet<int> setTwo = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                setOne.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());
                setTwo.Add(number);
            }

            foreach (int element in setOne.Intersect(setTwo))
            {
                Console.Write(element + " ");
            }



        }
    }
}
