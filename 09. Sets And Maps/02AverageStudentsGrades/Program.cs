namespace _02AverageStudentsGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, List<double>> students = new SortedDictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string name = input[0];
                double grade = double.Parse(input[1]);

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else 
                {
                    students[name] = new List<double>();
                    students[name].Add(grade);
                }       
            }

            foreach (var kvp in students)
            {
                double averageGrade = kvp.Value.Average();
                Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value.Select(v => v.ToString("F2")))} (avg: {averageGrade:F2})");
            }
        }
    }
}
