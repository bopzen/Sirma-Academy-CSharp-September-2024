namespace _12CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> occurances = new Dictionary<char, int>();
            foreach (char symbol in input)
            {
                if (symbol.ToString() != " ")
                {
                    if (!occurances.ContainsKey(symbol))
                    {
                        occurances[symbol] = 0;
                    }
                    occurances[symbol]++;
                }
            }
            foreach (var kvp in occurances)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
