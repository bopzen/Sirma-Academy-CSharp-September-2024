namespace _09GenericCountMethodDoubles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box<double>> boxes = new List<Box<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                var box = new Box<double>(input);
                boxes.Add(box);
            }

            double compareValue = double.Parse(Console.ReadLine());
            var compareBox = new Box<double>(compareValue);

            Console.WriteLine(CompareBoxes(boxes, compareBox));
        }

        static int CompareBoxes<T>(List<Box<T>> list, Box<T> element) where T : IComparable<T>
        {
            int counter = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
