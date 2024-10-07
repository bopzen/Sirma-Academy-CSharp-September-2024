namespace _10AddAndRemoveElementsFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split(",");
            int[] numbers = new int[commands.Length];
            int i = 0;
            int currentNumber = 1;
            foreach (string command in commands)
            {
                if (command == "add")
                {
                    numbers[i++] = currentNumber++;
                }
                else if (command == "remove")
                {
                    currentNumber++;
                }
            }
            bool isEmpty = true;
            foreach (int number in numbers)
            {
                if (number > 0)
                {
                    isEmpty = false;
                    Console.Write(number + " ");
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("Empty");
            }
        }
    }
}
