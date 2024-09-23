namespace _20CircleCircumference
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int radius = int.Parse(Console.ReadLine());
			Console.WriteLine($"{(2 * Math.PI * radius):F2}");
		}
	}
}
