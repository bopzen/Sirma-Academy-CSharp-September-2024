using System.Reflection.Metadata;

namespace _13ParkingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ");
                if (input[0] == "Register")
                {
                    string username = input[1];
                    string licensePlate = input[2];
                    if (users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {users[username]}");
                    }
                    else
                    {
                        users[username] = licensePlate;
                        Console.WriteLine($"{username} registered {licensePlate} successfully.");
                    }
                }
                else if (input[0] == "Unregister")
                {
                    string username = input[1];
                    if (!users.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: user {username} not found.");
                    }
                    else
                    {
                        users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully.");
                    }
                }
            }

            foreach (var kvp in users)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
