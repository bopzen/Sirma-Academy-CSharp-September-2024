namespace _08OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split(" ");
            Dictionary<string, int> counter = new Dictionary<string, int>();
            foreach (string word in input)
            {
                if (!counter.ContainsKey(word))
                {
                    counter[word] = 1;
                }
                else
                {
                    counter[word]++;
                }               
            }
            List<string> output = new List<string>();
            foreach (var kvp in counter)
            {
                if (kvp.Value % 2 != 0)
                {
                    output.Add(kvp.Key);
                }
            }
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
