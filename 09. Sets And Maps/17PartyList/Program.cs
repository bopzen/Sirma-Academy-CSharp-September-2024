namespace _17PartyList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> vipGuests = new HashSet<string>();
			HashSet<string> regularGuests = new HashSet<string>();
			HashSet<string> attended = new HashSet<string>();
			while (true)
			{
				string input = Console.ReadLine();
				if (input == "PARTY")
				{
					break;
				}

				if (char.IsDigit(input[0]))
				{
					vipGuests.Add(input);
				}
				else
				{
					regularGuests.Add(input);
				}
			}

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "END")
				{
					break;
				}

				vipGuests.Remove(input);
				regularGuests.Remove(input);
			}

			Console.WriteLine(vipGuests.Union(regularGuests).Count());
			foreach (string guest in vipGuests.Union(regularGuests))
			{
				Console.WriteLine(guest);
			}
		}
	}
}
