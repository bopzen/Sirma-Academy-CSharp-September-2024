namespace _19UniqueUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (!list.Contains(input))
                {
                    list.Add(input);
                }
            }
            foreach (string element in list)
            {
                Console.WriteLine(element);
            }
        }
    }
}
