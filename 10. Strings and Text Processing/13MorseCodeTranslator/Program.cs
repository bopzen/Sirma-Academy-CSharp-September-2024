namespace _13MorseCodeTranslator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, char> morseCodeLetters = new Dictionary<string, char>() 
            {
                { ".-", 'A' },
                { "-...", 'B' },
                { "-.-.", 'C' },
                { "-..", 'D' },
                { ".", 'E' },
                { "..-.", 'F' },
                { "--.", 'G' },
                { "....", 'H' },
                { "..", 'I' },
                { ".---", 'J' },
                { "-.-", 'K' },
                { ".-..", 'L' },
                { "--", 'M' },
                { "-.", 'N' },
                { "---", 'O' },
                { ".--.", 'P' },
                { "--.-", 'Q' },
                { ".-.", 'R' },
                { "...", 'S' },
                { "-", 'T' },
                { "..-", 'U' },
                { "...-", 'V' },
                { ".--", 'W' },
                { "-..-", 'X' },
                { "-.--", 'Y' },
                { "--..", 'Z' }
            };
            string[] input = Console.ReadLine().Split(" | ");
            foreach (string line in input)
            {
                string[] morseCode = line.Split(" ");
                foreach (var code in morseCode)
                {
                    Console.Write(morseCodeLetters[code]);
                }
                Console.Write(" ");
            }

        }
    }
}
