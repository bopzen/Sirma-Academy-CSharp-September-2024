namespace _05ExtractFile
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"..\..\..\presentation.pptx";

			string fileName = Path.GetFileNameWithoutExtension(filePath);
			string fileExtension = Path.GetExtension(filePath);
			Console.WriteLine($"File name: {fileName}");
			Console.WriteLine($"File extension: {fileExtension}");

			FileInfo fileInfo = new FileInfo(filePath);
			Console.WriteLine($"File size: {fileInfo.Length} bytes");
		}
	}
}
