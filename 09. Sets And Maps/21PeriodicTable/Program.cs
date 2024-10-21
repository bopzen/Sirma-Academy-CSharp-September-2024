namespace _21PeriodicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedSet<string> elements = new SortedSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                foreach (string s in input)
                {
                    elements.Add(s);
                }
            }
            foreach (string s in elements)
            {
                Console.Write(s + " ");
            }
        }
    }
}
