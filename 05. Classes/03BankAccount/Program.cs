using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace _03BankAccount
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<BankAccount> bankAccounts = new List<BankAccount>();
			while (true)
			{
				string command = Console.ReadLine();
				if (command == "End")
				{
					break;
				}

				if (command == "Create")
				{
					BankAccount bankAccount = new BankAccount();
					bankAccounts.Add(bankAccount);
					Console.WriteLine($"Account ID{bankAccount.Id} created");
				}
				string[] tokens = command.Split(" ");
				string action = tokens[0];
				if (action == "Deposit")
				{
					int accountId = int.Parse(tokens[1]);
					int amount = int.Parse(tokens[2]);
					bool isFound = false;
					foreach (var account in bankAccounts)
					{
						if (account.Id == accountId)
						{
							account.Deposit(amount);
							Console.WriteLine($"Deposited {amount} to ID{account.Id}");
                            isFound = true;
                            break;
						}
					}
                    if (!isFound)
                    {
                        Console.WriteLine("Acccount does not exist");
                    }
                }
				else if (action == "SetInterest")
				{
					double interest = double.Parse(tokens[1]);
					BankAccount.SetInterestRate(interest);
				}
				else if (action == "GetInterest")
				{
					int accountId = int.Parse(tokens[1]);
					int years = int.Parse(tokens[2]);
					bool isFound = false;
					foreach (var account in bankAccounts)
					{
						if (account.Id == accountId)
						{
							Console.WriteLine($"{account.GetInterest(years):F2}");
							isFound = true;
							break;
						}
					}
					if (!isFound)
					{
						Console.WriteLine("Acccount does not exist");
					}
				}
			}


		}
	}
	public class BankAccount
	{
		private static int idCounter = 1;
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
