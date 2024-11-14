namespace _10CopyFileContent
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string fileInputPath = @"..\..\..\input.txt";
			string fileOutputPath = @"..\..\..\output.txt";

			File.Copy(fileInputPath, fileOutputPath);
		}
	}
}
