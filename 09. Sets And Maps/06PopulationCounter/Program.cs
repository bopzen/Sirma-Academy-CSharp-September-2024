namespace _06PopulationCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> countryData = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> countryPopulation = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "report")
                {
                    break;
                }
                string[] tokens = input.Split("|");
                string city = tokens[0];
                string country = tokens[1];
                int population = int.Parse(tokens[2]);

                if (!countryData.ContainsKey(country))
                {
                    countryData[country] = new Dictionary<string, int>();
                    countryPopulation[country] = 0;                
                }
                countryData[country].Add(city, population);
                countryPopulation[country] += population;

            }

            var countryPopulationSorted = countryPopulation.OrderByDescending(x => x.Value);
            foreach (var country in countryPopulationSorted)
            {
                string countryName = country.Key;
                int totalPopulation = country.Value;
                Console.WriteLine($"{countryName} (total population: {totalPopulation})");

                var countryDataSorted = countryData[countryName].OrderByDescending(x => x.Value);
                foreach (var city in countryDataSorted)
                {
                    string cityName = city.Key;
                    int cityPopulation = city.Value;
                    Console.WriteLine($"=> {cityName}: {cityPopulation}");
                }
            }
        }
    }
}
