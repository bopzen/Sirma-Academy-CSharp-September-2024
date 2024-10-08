
namespace _12PasswordValidator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string password = Console.ReadLine();
			ValidatePassword(password);
		}

		private static void ValidatePassword(string password)
		{
			bool isValidLength = ValidateLength(password);
			bool isValidSymbols = ValidateSymbols(password);
			bool isValidMinDigits = ValidateMinDigits(password);
			if (isValidLength && isValidSymbols && isValidMinDigits)
			{
				Console.WriteLine("Password is valid");
			}
		}

		private static bool ValidateLength(string password)
		{
            if (!(password.Length >=6 && password.Length <= 10))
            {
				Console.WriteLine("Password must be between 6 and 10 characters");
				return false;
			}
			return true;
			
        }

		private static bool ValidateSymbols(string password)
		{
			foreach (char c in password)
			{
				if (!char.IsLetterOrDigit(c))
				{
					Console.WriteLine("Password must contain only letters and digits");
					return false;
				}
					
			}
			return true;
		}

		private static bool ValidateMinDigits(string password)
		{
			int digitsCount = 0;
			foreach (char c in password)
			{
				if (char.IsDigit(c))
				{
					digitsCount++;
					if (digitsCount == 2)
					{
						return true;
					}
				}
			}
			Console.WriteLine("Password must have at least 2 digits");
			return false;
		}
	}


}
