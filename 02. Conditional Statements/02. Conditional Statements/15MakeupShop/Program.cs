namespace _15MakeupShop
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double renovationPrice = double.Parse(Console.ReadLine());
			int powders = int.Parse(Console.ReadLine());
			int lipsticks = int.Parse(Console.ReadLine());
			int spirals = int.Parse(Console.ReadLine());
			int shadows = int.Parse(Console.ReadLine());
			int correctors = int.Parse(Console.ReadLine());

			double order = powders * 2.6 + lipsticks * 3 + spirals * 4.1 + shadows * 8.2 + correctors * 2;
			if (powders + lipsticks + spirals + shadows + correctors >= 50)
			{
				order-=order * 0.25;
			}
			order-=order * 0.1;

			if (order >= renovationPrice)
			{
				Console.WriteLine($"Yes! {(order - renovationPrice):F2} lv left.");
			} 
			else
			{
				Console.WriteLine($"Not enough money! {(renovationPrice - order):F2} lv needed.");
			}
		}
	}
}
