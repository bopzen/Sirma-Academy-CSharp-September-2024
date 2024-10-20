namespace _14StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            string name = "";
            for (int i = 0; i < 2 * n; i++)
            {
                string input = Console.ReadLine();
                if (i % 2 == 0)
                {
                    name = input;
                }
                else
                {
                    if (!students.ContainsKey(name))
                    {
                        students[name] = new List<double>();
                    }
                    students[name].Add(double.Parse(input));
                }
            }
            foreach (var kvp in students)
            {
                if (kvp.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
                }
            }

        }
    }
}
