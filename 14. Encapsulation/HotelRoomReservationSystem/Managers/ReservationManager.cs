using HotelRoomReservationSystem.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomReservationSystem.Managers
{
    public class ReservationManager
    {
        private const string ReservationsFilePath = @"..\..\..\data\reservations.json";
        List<Reservation> Reservations = new List<Reservation>();

        public ReservationManager() 
        {
            LoadReservationsFromFile(ReservationsFilePath);
        }

        private void LoadReservationsFromFile(string reservationsFilePath)
        {
            if (File.Exists(reservationsFilePath))
            {
                var jsonData = File.ReadAllText(reservationsFilePath);
                Reservations = JsonConvert.DeserializeObject<List<Reservation>>(jsonData);
            }
        }

        private void SaveReservationsToFile()
        {
            var jsonData = JsonConvert.SerializeObject(Reservations, Formatting.Indented);
            File.WriteAllText(ReservationsFilePath, jsonData);
        }
    }
}
