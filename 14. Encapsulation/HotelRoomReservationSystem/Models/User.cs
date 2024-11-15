using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomReservationSystem.Models
{
	public class User
	{
		public string Username { get; set; }
		public string Passwword { get; set; }
		List<Reservation> Reservations { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Passwword = password;
            Reservations = new List<Reservation>();
        }
    }
}
