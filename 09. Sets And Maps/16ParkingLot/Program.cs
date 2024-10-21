namespace _16ParkingLot
{
	internal class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> carsInParkingLot = new HashSet<string>();
			while (true)
			{
				string input = Console.ReadLine();
				if (input == "END")
				{
					break;
				}

				string[] tokens = input.Split(", ");
				string direction = tokens[0];
				string carNumber = tokens[1];

				if (direction == "IN")
				{
					carsInParkingLot.Add(carNumber);
				}
				else if (direction == "OUT")
				{
					carsInParkingLot.Remove(carNumber);
				}

				if (carsInParkingLot.Count == 0)
				{
					Console.WriteLine("Parking Lot is Empty");
				}
			}
			foreach (var carNumber in carsInParkingLot)
			{
				Console.WriteLine(carNumber);
			}
		}
	}
}
