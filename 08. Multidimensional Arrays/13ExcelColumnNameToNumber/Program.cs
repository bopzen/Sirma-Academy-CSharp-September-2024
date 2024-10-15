namespace _13ExcelColumnNameToNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string columnName = Console.ReadLine();
			int columnNumber = 0;

			foreach (var letter in columnName)
			{
				int letterNumber = (int)letter - 64;
				columnNumber = columnNumber*26 + letterNumber;
			}
			Console.WriteLine(columnNumber);
		}
	}
}
