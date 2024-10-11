namespace _09HotPotato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            int turns = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            foreach (string name in names)
            {
                queue.Enqueue(name);
            }

            while (queue.Count > 1)
            {
                for (int i = 1; i < turns; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                Console.WriteLine($"Removed {queue.Dequeue()}");
            }
            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
