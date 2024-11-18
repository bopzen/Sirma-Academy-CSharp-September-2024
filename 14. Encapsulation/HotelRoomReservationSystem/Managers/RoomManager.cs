﻿using HotelRoomReservationSystem.Models;
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