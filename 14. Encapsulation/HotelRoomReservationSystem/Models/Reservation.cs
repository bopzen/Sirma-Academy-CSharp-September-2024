using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomReservationSystem.Models
{
	public class Reservation
	{
		public string Id { get; set; }
		public int RoomNumber { get; set; }
		public string User { get; set; }
		public string ReservationStatus { get; set; }

		public Reservation(int roomNumber, string user) 
		{ 
			Id = Guid.NewGuid().ToString();
			RoomNumber = roomNumber;
			User = user;
			ReservationStatus = "Confirmed";
		}
	}
}
