namespace _04Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (true) {
                string input = Console.ReadLine();
                if (input == "search")
                {
                    break;
                }

                string[] tokens = input.Split("-");
                string name = tokens[0];
                string phoneNumber = tokens[1];
                phonebook[name] = phoneNumber;
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }

                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phonebook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} not found.");
                }
            }
        }
    }
}
