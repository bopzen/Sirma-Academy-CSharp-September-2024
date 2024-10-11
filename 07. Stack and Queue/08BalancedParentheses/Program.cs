using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace _08BalancedParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<string> stack = new Stack<string>();
            bool isBalanced = true;

            foreach (var character in input)
            {
                string item = character.ToString();
                if (item.Equals("{") || item.Equals("[") || item.Equals("("))
                {
                    stack.Push(item.ToString());
                }
                else
                {
                    if (item.Equals(")"))
                    {
                        if (stack.Peek().Equals("("))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                    else if (item.Equals("]"))
                    {
                        if (stack.Peek().Equals("["))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                    else if (item.Equals("}"))
                    {
                        if (stack.Peek().Equals("{"))
                        {
                            stack.Pop();
                        }
                        else
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(isBalanced);
        }
    }
}
