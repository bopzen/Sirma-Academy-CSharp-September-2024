namespace _07GenericSwapMethodIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> boxes = new List<Box<int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                var box = new Box<int>(input);
                boxes.Add(box);
            }
            int[] indices = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int indexOne = indices[0];
            int indexTwo = indices[1];
            SwapElements(boxes, indexOne, indexTwo);
            foreach (Box<int> box in boxes)
            {
                Console.WriteLine(box);
            }
        }

        static void SwapElements<T>(List<T> list, int indexOne, int indexTwo)
        {
            if (indexOne < 0 || indexTwo < 0 || indexOne >= list.Count || indexTwo >= list.Count)
            {
                throw new ArgumentOutOfRangeException();
            }
            T temp = list[indexOne];
            list[indexOne] = list[indexTwo];
            list[indexTwo] = temp;
        }
    }
}
