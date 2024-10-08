namespace _07Students
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<Student> students = new List<Student>();
			while (true)
			{
				string command = Console.ReadLine();
				if (command == "end")
				{
					break;
				}
				string[] tokens = command.Split(" ");
				string firstName = tokens[0];
				string lastName = tokens[1];
				int age = int.Parse(tokens[2]);
				string hometown = tokens[3];
				Student student = new Student(firstName, lastName, age, hometown);
				students.Add(student);
			}
			string city = Console.ReadLine();
			foreach (Student student in students.Where(p => p.Hometown.Equals(city)))
			{
				Console.WriteLine(student);
			}

		}

	}

	public class Student 
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public string Hometown { get; set; }

		public Student(string firstName, string lastName, int age, string hometown) 
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Hometown = hometown;
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName} is {Age} years old";
		}

	}

}
