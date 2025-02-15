﻿using HotelRoomReservationSystem.Models;
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

        public void CreateReservation(int roomNumber, string username)
        {
            Reservation reservation = new Reservation(roomNumber, username);
            Reservations.Add(reservation);
            SaveReservationsToFile();
        }

        public List<Reservation> GetAllReservationsForUser(string userName)
        {
            var reservations = Reservations.Where(r => r.User == userName).ToList();
            return reservations;
        }

        public int CancelReservation(string reservationNumber)
        {
            Reservation reservation = Reservations.FirstOrDefault(r => r.Id == reservationNumber);
            if (reservation != null) 
            {
                reservation.ReservationStatus = "Cancelled";
                SaveReservationsToFile();
                Console.WriteLine($"Reservation number {reservation.Id} cancelled successfully");
                return reservation.RoomNumber;
            }
            else
            {
                Console.WriteLine($"Reservation number {reservationNumber} not found");
                return 0;
            }
            
        }
    }
}
