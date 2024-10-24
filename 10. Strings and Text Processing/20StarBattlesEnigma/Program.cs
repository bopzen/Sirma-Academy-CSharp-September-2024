namespace _20StarBattlesEnigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> decryptedMessages = new List<string>();

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
                Console.WriteLine(message);
            }
        }
    }
}
