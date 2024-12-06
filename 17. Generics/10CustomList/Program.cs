namespace _10CustomList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<string> customList = new CustomList<string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ");

                if (command[0] == "Add")
                {
                    var element = command[1];
                    customList.Add(element);

                }
                else if (command[0] == "Remove")
                {
                    int index = int.Parse(command[1]);
                    customList.Remove(index);
                }
                else if (command[0] == "Contains")
                {
                    var element = command[1];
                    Console.WriteLine(customList.Contains(element));
                }
                else if (command[0] == "Swap")
                {
                    int indexOne = int.Parse(command[1]);
                    int indexTwo = int.Parse(command[2]);
                    customList.Swap(indexOne, indexTwo);
                }
                else if (command[0] == "Greater")
                {
                    var element = command[1];
                    Console.WriteLine(customList.CountGreaterThan(element));
                }
                else if (command[0] == "Max")
                {
                    Console.WriteLine(customList.GetMax());
                }
                else if (command[0] == "Min")
                {
                    Console.WriteLine(customList.GetMin());
                }
                else if (command[0] == "Print")
                {
                    customList.Print();
                }
                else if (command[0] == "end")
                {
                    break;
                }
            }
        }
    }
}
