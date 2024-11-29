namespace ShapeAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>
            {
                new Circle(5),
                new Rectangle(4, 6),
                new Triangle(5, 8)
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"{shape.GetType().Name} has area {shape.GetArea():F2}");
            }

            //TODO Extensions when I have more time
        }
    }
}
