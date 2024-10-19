namespace _07WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            string word = "";
            for (int i = 0; i < 2 * n; i++)
            {
                string input = Console.ReadLine();
                if (i % 2 == 0)
                {
                    if (!words.ContainsKey(input))
                    {
                        words[input] = new List<string>();
                        word = input;
                    }
                    
                }
                else
                {
                    if (!words[word].Contains(input))
                    {
                        words[word].Add(input);
                    }
                }
            }

            foreach (var kvp in words)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
