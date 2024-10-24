using System.Text.RegularExpressions;

namespace _20StarBattlesEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> decryptedMessages = new List<string>();
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            string pattern = @"@(?<Planet>[A-z]+)[^@\-!:>]*:(?<Population>\d+)[^@\-!:>]*!(?<AttackType>[AD])![^@\-!:>]*->(?<SoldiersCount>\d+)";
            Regex regex = new Regex(pattern);

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                int counter = 0;
                foreach (var letter in encryptedMessage)
                {
                    char symbol = char.ToLower(letter);
                    if (symbol == 's' || symbol == 't' || symbol == 'a' || symbol == 'r')
                    {
                        counter++;
                    }
                }
                string decryptedMessage = "";
                foreach (char letter in encryptedMessage)
                {
                    char newLetter = (char)((int)letter - counter);
                    decryptedMessage += newLetter;
                }
                decryptedMessages.Add(decryptedMessage);
            }
            foreach (var message in decryptedMessages)
            {
                Match match = regex.Match(message);
                if (match.Success)
                {
                    if (match.Groups["AttackType"].Value == "A")
                    {
                        attackedPlanets.Add(match.Groups["Planet"].Value);
                    }
                    else
                    {
                        destroyedPlanets.Add(match.Groups["Planet"].Value);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (var planet in destroyedPlanets)
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
