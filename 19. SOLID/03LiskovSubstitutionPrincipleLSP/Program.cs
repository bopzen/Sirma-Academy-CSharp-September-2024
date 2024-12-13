namespace _03LiskovSubstitutionPrincipleLSP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>
            {
                new CombustionEngine(),
                new ElectricEngine(),
            };

            foreach (Engine engine in engines)
            {
                engine.Start();
            }


            List<Bird> birds = new List<Bird>
            {
                new Penguin(),
                new Eagle()
            };

            foreach(Bird bird in birds)
            {
                bird.Move();
            }

            List<IFlyable> flyableBirds = new List<IFlyable>
            {
                new Eagle(),
                new Eagle()
            };

            foreach (IFlyable flyable in flyableBirds)
            {
                flyable.Fly();
            }
        }
    }
}
