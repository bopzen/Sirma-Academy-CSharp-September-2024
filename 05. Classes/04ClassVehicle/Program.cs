namespace _04ClassVehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine(163);
            Vehicle vehicle = new Vehicle("BMW", "320d", engine, 200);
            vehicle.Drive(100);
            Console.WriteLine(vehicle.Fuel);
        }
    }

    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Fuel { get; set; }

        public Vehicle(string type, string model, Engine engine, int fuel)
        {
            Type = type;
            Model = model;
            Engine = engine;
            Fuel = fuel;
        }

        public void Drive(int fuelLoss)
        {
            this.Fuel -= fuelLoss;
        }
    }

    public class Engine
    {
        public int Power { get; set; }
        public Engine(int power)
        {
            this.Power = power;
        }

    }
}
