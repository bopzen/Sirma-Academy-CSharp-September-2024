namespace _02OpenClosedPrincipleOCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double amount = 100;

            string discountType = "SENIOR";

            IDiscountStrategy strategy = DiscountFactory.GetDiscountStrategy(discountType);
            DiscountService discountService = new DiscountService(strategy);
            Console.WriteLine(discountService.CalculateDiscount(amount));
        }
    }
}
