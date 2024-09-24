namespace _21UniversityAdmissions
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int score = int.Parse(Console.ReadLine());
			int extra = int.Parse(Console.ReadLine());
			if (score >= 90)
			{
				Console.WriteLine("Admitted");
			}
			else if (score >= 80)
			{
				if (extra >= 2)
				{
					Console.WriteLine("Admitted");
				}
				else
				{
					Console.WriteLine("Not admitted");
				}
			}
			else
			{
				Console.WriteLine("Not admitted");
			}
		}
	}
}
