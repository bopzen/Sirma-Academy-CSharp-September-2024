namespace _01SumFirstAndLastArrayElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(",");
            Console.WriteLine(int.Parse(array[0]) + int.Parse(array[array.Length-1]));
        }
    }
}
