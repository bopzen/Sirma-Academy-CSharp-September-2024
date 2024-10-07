namespace _19ArrayManipulations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] array = Console.ReadLine().Split(" ");
			string[] commands = Console.ReadLine().Split(", ");

			foreach ( string command in commands )
			{
				string[] tokens = command.Split(" ");
				string action = tokens[0];

				if (action == "Add")
				{
					string number = tokens[1];
					string[] temp = new string[array.Length+1];
					for (int i = 0; i < array.Length; i++)
					{
						temp[i] = array[i];
					}
					temp[array.Length] = number;
					array = temp;
				}
				else if (action =="Remove")
				{
					string number = tokens[1];

					int counter = 0;
					foreach (var item in array)
					{
						if (item == number)
						{
							counter++;
						}
					}

					string[] temp = new string[array.Length-counter];
					int i = 0;
					foreach (var item in array)
					{
						if (item != number)
						{
							temp[i++] = item;
						}				
					}
					array = temp;
				}
				else if (action == "RemoveAt")
				{
					int index = int.Parse(tokens[1]);
					string[] temp = new string[array.Length - 1];
					int j = 0;
					for(int i = 0; i < array.Length; i++)
					{
						if (i != index)
						{
							temp[j++] = array[i];
						}
					}
					array = temp;
				}
				else if (action == "Insert")
				{
					string number = tokens[1];
					int index = int.Parse(tokens[2]);
					string[] temp = new string[array.Length + 1];
					int j = 0;
					for (int i = 0; i < array.Length; i++)
					{
                        if (j == index)
                        {
							temp[j++] = number;
						}
                        temp[j++] = array[i];
					}
					array = temp;
				}

			}
			
			Console.WriteLine(string.Join(" ", array));
		}
	}
}
