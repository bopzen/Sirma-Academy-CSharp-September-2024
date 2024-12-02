namespace _01JarOfT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jar<string> jar = new Jar<string>();

            jar.Add("biscuit");
            jar.Add("chocolate");
            jar.Add("cookie");

            Console.WriteLine(jar.Remove());
        }
    }
}
