using HotelRoomReservationSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomReservationSystem
{
    public class UserManager
    {
        private const string UserFilePath = @"..\..\..\data\users.json";
        List<User> Users = new List<User>();

        public UserManager() 
        {
            LoadUsersFromFile();
        }

        private void LoadUsersFromFile()
        {
            if (File.Exists(UserFilePath))
            {
                var jsonData = File.ReadAllText(UserFilePath);
                Users = JsonConvert.DeserializeObject<List<User>>(jsonData);
            }
        }

        private void SaveUsersToFile()
        {
            var jsonData = JsonConvert.SerializeObject(Users, Formatting.Indented);
            File.WriteAllText(UserFilePath, jsonData);
        }

        public User RegisterUser()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            if (Users.Any(u => u.Username == username))
            {
                Console.WriteLine($"Username {username} already exists.");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                return null;
            }

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User newUser = new User(username, password);
            Users.Add(newUser);
            SaveUsersToFile();
            return newUser;
        }

        public User LoginUser()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User user = Users.FirstOrDefault(u => u.Username == username && u.Passwword == password);

            if (user != null)
            {
                Console.WriteLine($"Welcome, {username}!");
                return user;
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                return null;
            }
        }

        public void ShowProfileDetails(User user)
        {
            if (user != null)
            {
                Console.WriteLine($"Username: {user.Username}");
            }
            else
            {
                Console.WriteLine("You are not logged in.");
            }

            Console.Write("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
