namespace _02CarConstructors
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
				if (input.Length == 1)
				{
					Car car = new Car(input[0]);
					cars[i] = car;
				}
				else if (input.Length == 2)
				{
					Car car = new Car(input[0], input[1]);
					cars[i] = car;
				}
				else
				{
					Car car = new Car(input[0], input[1], int.Parse(input[2]));
					cars[i] = car;
				}

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

		public Car(string brand) 
		{
			Brand = brand;
			Model = "unknown";
			Horsepower = -1;
		}

		public Car(string brand, string model): this(brand)
		{ 
			Model = model;
			Horsepower = -1;
		}
		public Car(string brand, string model, int horsepower) : this(brand)
		{
			Model = model;
			Horsepower = horsepower;
		}

		public string CarInfo()
		{
			return $"The car is: {this.Brand} {this.Model} - {this.Horsepower} HP.";
		}
	}
}
