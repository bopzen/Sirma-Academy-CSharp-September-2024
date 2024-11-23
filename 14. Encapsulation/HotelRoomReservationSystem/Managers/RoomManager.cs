using HotelRoomReservationSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomReservationSystem.Managers
{
    public class RoomManager
    {
        private const string RoomTypesFilePath = @"..\..\..\data\room-types.json";
        private const string RoomsFilePath = @"..\..\..\data\rooms.json";
        List<RoomType> RoomTypes = new List<RoomType>();
        List<Room> Rooms = new List<Room>();

        public RoomManager() 
        {
            LoadRoomTypesFromFile(RoomTypesFilePath);
            LoadRoomsFromFile(RoomsFilePath);
        }

        private void LoadRoomTypesFromFile(string roomTypesFilePath)
        {
            if (File.Exists(roomTypesFilePath))
            {
                var jsonData = File.ReadAllText(roomTypesFilePath);
                RoomTypes = JsonConvert.DeserializeObject<List<RoomType>>(jsonData);
            }
        }

        private void LoadRoomsFromFile(string roomsFilePath)
        {
            if (File.Exists(roomsFilePath))
            {
                var jsonData = File.ReadAllText(roomsFilePath);
                Rooms = JsonConvert.DeserializeObject<List<Room>>(jsonData);
            }
        }

        private void SaveRoomsToFile()
        {
            var jsonData = JsonConvert.SerializeObject(Rooms, Formatting.Indented);
            File.WriteAllText(RoomsFilePath, jsonData);
        }

        public void ShowAllRoomTypes()
        {
            foreach (var roomType in RoomTypes)
            {
                Console.WriteLine(roomType.Name);
                Console.WriteLine($"  -  Max Occupancy: {roomType.MaxOccupancy}");
                Console.WriteLine($"  -  Amenities: {string.Join(", ", roomType.Amenities)}");
                Console.WriteLine();
            }
        }

        public List<Room> GetAvailableRoomsOfType(string roomType)
        {
            var availableRooms = Rooms.Where(r => r.Type == roomType && r.Status == "Available").ToList();
            return availableRooms;
        }



        public List<Room> PrintAvailableRoomsOfType(string roomType)
        {
            Console.WriteLine($"Available {roomType}s");
            Console.WriteLine("-------------------------------");
            var availableRooms = GetAvailableRoomsOfType(roomType);
            if (availableRooms.Count > 0)
            {
                foreach (var room in availableRooms)
                {
                    Console.WriteLine($" Room Number: {room.RoomNumber}");
                    Console.WriteLine($" Room Type: {room.Type}");
                    Console.WriteLine($" Price per Night: {room.PricePerNight}");
                    Console.WriteLine($" Cancellation Fee: {room.CancellationFee}");
                    Console.WriteLine($" Status: {room.Status}");
                    Console.WriteLine("-------------------------------");
                }
            }
            else
            {
                Console.WriteLine($"No available {roomType}");
            }   
            return availableRooms;
        }

        public void BookRoomByRoomNumber(int roomNumber)
        {
            Room room = Rooms.FirstOrDefault(x => x.RoomNumber == roomNumber);
            room.Status = "Booked";
            SaveRoomsToFile();
            Console.WriteLine($"Room {room.RoomNumber} booked successfully!");
        }
    }
}
