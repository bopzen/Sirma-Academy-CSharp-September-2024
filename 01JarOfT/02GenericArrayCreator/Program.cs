namespace _02GenericArrayCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var array1 = ArrayCreator<string>.Create(10, "test");
            var array2 = ArrayCreator<int>.Create(typeof(int), 10, 1);
            Console.WriteLine(string.Join(" ", array1));
            Console.WriteLine(string.Join(" ", array2));
        }
    }
}
