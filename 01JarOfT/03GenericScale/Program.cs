namespace _03GenericScale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scale = new Scale<int>(10, 20);
            Console.WriteLine(scale.GetHeavier());
        }
    }
}
