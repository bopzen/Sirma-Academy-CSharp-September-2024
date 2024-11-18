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
        private const string RoomTypeFilePath = @"..\..\..\data\room-types.json";
        List<RoomType> RoomTypes = new List<RoomType>();
        List<Room> Rooms = new List<Room>();

        public RoomManager() 
        {
            LoadRoomTypesFromFile(RoomTypeFilePath);
            LoadRoomsFromFile(RoomTypeFilePath);
        }

        private void LoadRoomTypesFromFile(string roomTypeFilePath)
        {
            if (File.Exists(roomTypeFilePath))
            {
                var jsonData = File.ReadAllText(roomTypeFilePath);
                RoomTypes = JsonConvert.DeserializeObject<List<RoomType>>(jsonData);
            }
        }

        private void LoadRoomsFromFile(string roomTypeFilePath)
        {

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
    }
}
