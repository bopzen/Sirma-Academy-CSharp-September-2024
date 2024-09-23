namespace _08AlarmAfter15Minutes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int hour = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			int newHour = hour;
			int newMinutes = minutes + 15;
			if (newMinutes >= 60)
			{
				newMinutes = newMinutes - 60;
				newHour++;
				if (newHour > 23)
				{
					newHour = 0;
				}
			}
			Console.WriteLine($"{newHour:D1}:{newMinutes:D2}");
		}
	}
}
