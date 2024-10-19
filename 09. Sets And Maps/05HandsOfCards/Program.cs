namespace _05HandsOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            Dictionary<string, int> types = new Dictionary<string, int>()
            {
                {"S", 4},
                {"H", 3},
                {"D", 2},
                {"C", 1},
            };
            Dictionary<string, int> powers = new Dictionary<string, int>()
            {
                {"J", 11},
                {"Q", 12},
                {"K", 13},
                {"A", 14},
            };
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "JOKER")
                {
                    break;
                }
                string[] tokens = input.Split(": ");
                string name = tokens[0];
                string[] cards = tokens[1].Split(", ");
                foreach (string card in cards)
                {
                    if (players.ContainsKey(name))
                    {
                        if (!players[name].Contains(card))
                        {
                            players[name].Add(card);
                        }
                    }
                    else
                    {
                        players[name] = new List<string>();
                        players[name].Add(card);
                    }
                }
            }
            foreach (var kvp in players)
            {
                int sum = 0;
                foreach (string card in kvp.Value)
                {
                    int typeValue = types[card[card.Length - 1].ToString()];
                    string power = card.Remove(card.Length - 1);
                    int powerValue;
                    if (powers.ContainsKey(power))
                    {
                        powerValue = powers[power];
                    }
                    else
                    {
                        powerValue = int.Parse(power);
                    }

                    sum += typeValue * powerValue;
                }
                Console.WriteLine($"{kvp.Key}: {sum}");
            }
        }
    }
}
