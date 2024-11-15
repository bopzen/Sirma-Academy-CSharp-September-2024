using System.Xml.Linq;

namespace _12SerializeCustomObjectList
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string filePath = @"..\..\..\persons.dat";
			List<Person> persons = new List<Person>
			{
				new Person("Ivan", 18),
				new Person("Georgi", 20),
				new Person("Maria", 25),
				new Person("Petar", 37),
			};

			Console.WriteLine("Initial data:");
			foreach (Person person in persons)
			{
				Console.WriteLine($"{person.Name} {person.Age}");
			}

			SavePersonsToFile(persons, filePath);
			List<Person> loadedPersons = LoadPersonsFromFile(filePath);

			Console.WriteLine("Loaded data:");
			foreach (Person person in loadedPersons)
			{
				Console.WriteLine($"{person.Name} {person.Age}");
			}


			static void SavePersonsToFile(List<Person> personsList, string filePath)
			{
				using (FileStream fs = new FileStream(filePath, FileMode.Create))
				using (BinaryWriter bw = new BinaryWriter(fs)) 
				{

					bw.Write(personsList.Count);

					foreach (Person person in personsList)
					{
						bw.Write(person.Name);
						bw.Write(person.Age);
					}
				}
			}

			static List<Person> LoadPersonsFromFile(string filePath)
			{
				List<Person> personsList = new List<Person>();

				using (FileStream fs = new FileStream(filePath, FileMode.Open))
				using (BinaryReader br = new BinaryReader(fs))
				{
					int count = br.ReadInt32();

					for (int i = 0; i < count; i++)
					{
						string name = br.ReadString();
						int age = br.ReadInt32();
						personsList.Add(new Person(name, age));
					}
				}

				return personsList;
			}
		}
	}
}
