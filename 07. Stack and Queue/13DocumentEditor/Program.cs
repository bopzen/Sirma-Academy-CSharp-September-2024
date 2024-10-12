namespace _13DocumentEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            Stack<string> stack2 = new Stack<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End") 
                {
                    break;
                }
                if (input == "Undo()")
                {
                    stack2.Push(stack.Pop());
                }
                else if (input == "Redo()")
                {
                    stack.Push(stack2.Pop());
                }
                else
                {
                    input = input.Replace("Insert(\"", "");
                    input = input.Replace("\")", "");
                    stack.Push(input);

                }
                string[] stackArray = stack.ToArray();
                Array.Reverse(stackArray);
                foreach (string item in stackArray)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }

        }
    }
}
