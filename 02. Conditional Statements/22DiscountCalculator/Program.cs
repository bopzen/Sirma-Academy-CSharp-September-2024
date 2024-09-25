namespace _22DiscountCalculator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int age = int.Parse(Console.ReadLine());
			string membership = Console.ReadLine();

			if (age >0 && age < 18) 
			{
				Console.WriteLine("10% discount");
			}
			else if (age >= 18 && age <= 64)
			{
				if (membership == "Yes")
				{
					Console.WriteLine("20% discount");
				}
				else if (membership == "No")
				{
					Console.WriteLine("10% discount");
				}
                else
                {
					Console.WriteLine("error");
                }
            }
            else
            {
				Console.WriteLine("30% discount");
			}

        }
	}
}
