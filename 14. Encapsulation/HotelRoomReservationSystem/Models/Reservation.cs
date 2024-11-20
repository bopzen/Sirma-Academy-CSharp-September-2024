using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomReservationSystem.Models
{
	public class Reservation
	{
		public int Id { get; set; }
		public int RoomNumber { get; set; }
		public string User { get; set; }
		public string ReservationStatus { get; set; }
	}
}
