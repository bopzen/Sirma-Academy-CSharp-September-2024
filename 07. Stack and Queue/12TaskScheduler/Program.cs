
namespace _12TaskScheduler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> queue = new PriorityQueue<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                if (input == "getNextTask")
                {
                    Console.WriteLine(GetNextTask(queue));
                }
                else
                {
                    string[] tokens = input.Split(" ");
                    string task = tokens[1];
                    int priority = int.Parse(tokens[2]);
                    queue.Enqueue(task, -priority);
                }
            }
        }

        private static string GetNextTask(PriorityQueue<string, int> queue)
        {
            return queue.Peek();
        }
    }
}
