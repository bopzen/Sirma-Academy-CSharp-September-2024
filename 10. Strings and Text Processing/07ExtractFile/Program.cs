namespace _07ExtractFile
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string path = Console.ReadLine();
			int indexStart = path.LastIndexOf("\\");
			int indexDot = path.LastIndexOf(".");
			Console.WriteLine(path.Substring(indexStart + 1, indexDot - 1 - indexStart));
			Console.WriteLine(path.Substring(indexDot + 1));
		}
	}
}
