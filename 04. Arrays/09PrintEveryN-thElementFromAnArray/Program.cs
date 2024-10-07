namespace _09PrintEveryN_thElementFromAnArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(",");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i += n)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
