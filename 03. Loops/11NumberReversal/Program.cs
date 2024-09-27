namespace _11NumberReversal
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string number = n.ToString();
			string newNumber = "";
			for (int i = number.Length-1; i >= 0; i--)
			{
				newNumber += number[i];
			}
			Console.WriteLine(newNumber);
		}
	}
}
