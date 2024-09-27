namespace _19PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceLightsaber = double.Parse(Console.ReadLine());
            double priceRobe = double.Parse(Console.ReadLine());
            double priceBelt = double.Parse(Console.ReadLine());
            int freeBelts = studentsCount / 6;
            double cost = Math.Ceiling(priceLightsaber * studentsCount * 1.1) + priceRobe * studentsCount + priceBelt * (studentsCount - freeBelts);
            if (cost <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {cost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"George Lucas will need {cost - budget}lv more");
            }
        }
    }
}
