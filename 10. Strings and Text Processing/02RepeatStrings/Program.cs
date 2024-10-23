using System.Text;

namespace _02RepeatStrings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] inputArray = Console.ReadLine().Split(" ");
			StringBuilder sb = new StringBuilder();
			foreach (string input in inputArray)
			{
				for (int i = 0; i < input.Length; i++)
				{
					sb.Append(input);
				}
			}
			Console.WriteLine(sb.ToString());
		}
	}
}
