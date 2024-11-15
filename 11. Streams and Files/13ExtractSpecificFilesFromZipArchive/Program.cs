using System.IO.Compression;

namespace _13ExtractSpecificFilesFromZipArchive
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"..\..\..\archive.zip";
			string currentPath = Directory.GetCurrentDirectory();
			string destinationDirectory = Path.GetFullPath(Path.Combine(currentPath, "..", "..", "..", "extracted_files"));

			Directory.CreateDirectory(destinationDirectory);

			using (ZipArchive zip = ZipFile.OpenRead(filePath))
			{
				foreach (var entry in zip.Entries)
				{
					if (Path.GetExtension(entry.FullName).Equals(".txt", StringComparison.OrdinalIgnoreCase))
					{
						string destinationPath = Path.Combine(destinationDirectory, entry.Name);

						entry.ExtractToFile(destinationPath, overwrite: true);
						Console.WriteLine($"Extracted: {entry.Name}");
					}
				}
			}
			Console.WriteLine($"All .txt files have been extracted to '{destinationDirectory}'.");
		}
	}
}
