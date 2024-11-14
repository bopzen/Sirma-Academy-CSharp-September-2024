using System.Text;

namespace _06ReverseLines
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string fileInputPath = @"..\..\..\input.txt";
			string fileOutputPath = @"..\..\..\output.txt";

			StringBuilder sb = new StringBuilder();

			using (StreamReader reader = new StreamReader(fileInputPath))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					sb.AppendLine(new string(line.ToCharArray().Reverse().ToArray()));
				}
			}

			using (StreamWriter writer = new StreamWriter(fileOutputPath))
			{
				writer.WriteLine(sb.ToString());
			}
		}
	}
}
