namespace _15CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] tokens = input.Split(" -> ");
                string company = tokens[0];
                string employeeId = tokens[1];

                if (!companies.ContainsKey(company))
                {
                    companies[company] = new List<string>();
                }
                if (!companies[company].Contains(employeeId))
                {
                    companies[company].Add(employeeId);
                }
            }

            foreach (var kvp in companies)
            {
                Console.WriteLine(kvp.Key);
                foreach (var employeeId in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }

        }
    }
}
