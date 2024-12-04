namespace _08GenericCountMethodStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> boxes = new List<Box<string>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var box = new Box<string>(input);
                boxes.Add(box);
            }

            string compareValue = Console.ReadLine();
            var compareBox = new Box<string>(compareValue);

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
