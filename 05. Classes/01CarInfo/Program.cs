namespace _01CarInfo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Car[] cars = new Car[n];
            for (int i = 0; i < cars.Length; i++)
            {
				string[] input = Console.ReadLine().Split(" ");
				Car car = new Car();
				car.Brand = input[0];
				car.Model = input[1];
				car.Horsepower = int.Parse(input[2]);
				cars[i] = car;
            }
			foreach (Car car in cars)
			{
				Console.WriteLine(car.CarInfo());
			}
        }
	}

	public class Car
	{
		public string Brand { get; set; }
		public string Model { get; set; }
		public int Horsepower { get; set; }

		public string CarInfo()
		{
			return $"Info: {this.Brand} {this.Model} - {this.Horsepower} HP.";
		}
	}

}
