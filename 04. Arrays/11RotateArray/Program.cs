namespace _11RotateArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(",");
            int n = int.Parse(Console.ReadLine());
            string[] newArray = new string[array.Length];

            for (int i = 0; i < array.Length; i++) 
            {
                newArray[(i + n) % array.Length] = array[i];
            }
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}
