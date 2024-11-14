using System.Text.RegularExpressions;

namespace _08MergeLinesFromTwoFiles
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string fileInputOnePath = @"..\..\..\input1.txt";
			string fileInputTwoPath = @"..\..\..\input2.txt";
			string fileOutputPath = @"..\..\..\output.txt";


			using StreamReader reader1 = new StreamReader(fileInputOnePath);
			using StreamReader reader2 = new StreamReader(fileInputTwoPath);
			using StreamWriter writer = new StreamWriter(fileOutputPath);

			string line1, line2;
			while ((line1 = reader1.ReadLine()) != null | (line2 = reader2.ReadLine()) != null)
			{
				if (line1 != null)
				{
					writer.WriteLine(line1);
				}

				if (line2 != null)
				{
					writer.WriteLine(line2);
				}
			}
		}
	}
}
