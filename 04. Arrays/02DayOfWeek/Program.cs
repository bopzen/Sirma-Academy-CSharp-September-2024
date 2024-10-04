namespace _02DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekdays =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int n = int.Parse(Console.ReadLine());
            if ( n>= 1 && n <= 6)
            {
                Console.WriteLine(weekdays[n-1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
