namespace _10CitiesByContinentAndCountry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> data = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!data.ContainsKey(continent)) 
                {
                    data[continent] = new Dictionary<string, List<string>>();               
                }
                if (!data[continent].ContainsKey(country))
                {
                    data[continent].Add(country, new List<string>());
                }
                data[continent][country].Add(city);
            }
            foreach (var kvp in data)
            {
                Console.WriteLine(kvp.Key + ":");
                foreach (var kvp2 in kvp.Value)
                {
                    Console.WriteLine($" {kvp2.Key} -> {string.Join(", ", kvp2.Value)}");
                }
            }
        }
    }
}
