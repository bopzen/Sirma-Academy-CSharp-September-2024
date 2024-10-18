namespace _03CountSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> symbols = new SortedDictionary<char, int>();

            foreach (var symbol in input)
            {
                if (symbols.ContainsKey(symbol))
                {
                    symbols[symbol]++;
                }
                else
                {
                    symbols[symbol] = 1;
                }
            }

            foreach (var symbol in symbols.Keys)
            {
                {
                    Console.WriteLine($"{symbol}: {symbols[symbol]}");
                }
            }
        }
    }
}
