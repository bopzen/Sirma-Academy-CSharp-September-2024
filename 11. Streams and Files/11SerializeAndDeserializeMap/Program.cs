using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

namespace _11SerializeAndDeserializeMap
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> map = new Dictionary<string, int> 
			{
				{ "Apple", 10 },
				{ "Banana", 20 },
				{ "Orange", 30 }
			};

			string filePath = @"..\..\..\map.dat";

			SaveMapToFile(map, filePath);

			static void SaveMapToFile(Dictionary<string, int> map, string filePath)
			{
				using (FileStream fs = new FileStream(filePath, FileMode.Create))
				using (BinaryWriter writer = new BinaryWriter(fs))
				{
					writer.Write(map.Count);

					foreach (var kvp in map)
					{
						writer.Write(kvp.Key);
						writer.Write(kvp.Value);
					}
				}
			}
		}
	}
}
