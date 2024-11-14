namespace _09CalculateDirectorySize
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string currentPath = Directory.GetCurrentDirectory();
			string directoryPath = Path.GetFullPath(Path.Combine(currentPath, "..", "..", ".."));

			long totalSize = GetDirectorySize(directoryPath);

			Console.WriteLine($"Total size: {totalSize} bytes");

			static long GetDirectorySize(string path)
			{
				long size = 0;
				string[] files = Directory.GetFiles(path);
				foreach (string file in files)
				{
					FileInfo fileInfo = new FileInfo(file);
					size += fileInfo.Length;
				}

				string[] subdirectories = Directory.GetDirectories(path);
				foreach (string subdir in subdirectories)
				{
					size += GetDirectorySize(subdir);
				}

				return size;
			}
		}
	}
}
