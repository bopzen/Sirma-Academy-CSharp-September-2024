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

			Dictionary<string, int> loadedMap = LoadMapFromFile(filePath);

			foreach (var kvp in loadedMap)
			{
				Console.WriteLine($"{kvp.Key}: {kvp.Value}");
			}

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

			static Dictionary<string, int> LoadMapFromFile(string filePath)
			{
				Dictionary<string, int> map = new Dictionary<string, int>();

				using (FileStream fs = new FileStream(filePath, FileMode.Open))
				using (BinaryReader reader = new BinaryReader(fs))
				{
					int count = reader.ReadInt32();

					for (int i = 0; i < count; i++)
					{
						string key = reader.ReadString();
						int value = reader.ReadInt32();
						map[key] = value;
					}
				}

				return map;
			}
		}
	}
}
