namespace _03BankAccount
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string command = "";
			while (command != "End")
			{
				command = Console.ReadLine();

			}
		}
	}

	public class BankAccount
	{
		private int idCounter = 1;
		private int id;
		private double balance;
		private static double interestRate = 0.02;

		public int Id 
		{ get 
			{ 
				return id; 
			} 
		}

		public BankAccount()
		{
			this.id = idCounter++;
			this.balance = 0;
		}

		public static void SetInterestRate(double interest)
		{
			interestRate = interest;
		}

		public double GetInterest(int years)
		{
			return interestRate * this.balance * years;
		}

		public void Deposit(double amount)
		{
			if (amount > 0)
			{
				this.balance += amount;
			}
			else
			{
				Console.WriteLine("Wrong deposit amount");
			}
		}
	}
}
