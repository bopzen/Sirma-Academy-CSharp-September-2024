namespace _20RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            int trashedHeadsets = lostGames / 2;
            int trashedMice = lostGames / 3;
            int trashedKeyboards = lostGames / 6;
            int trashedDisplays = lostGames / 12;

            double expenses = trashedHeadsets * priceHeadset + trashedMice * priceMouse + trashedKeyboards * priceKeyboard + trashedDisplays * priceDisplay;
            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
