namespace _10MaximumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input == "2")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (input == "3")
                {
                    int max = int.MinValue;
                    foreach (var item in stack)
                    {
                        if (item > max)
                        {
                            max = item;
                        }
                    }
                    Console.WriteLine(max);
                }
                else
                {
                    int number = int.Parse(input.Split(" ")[1]);
                    stack.Push(number);
                }
            }

        }
    }
}
