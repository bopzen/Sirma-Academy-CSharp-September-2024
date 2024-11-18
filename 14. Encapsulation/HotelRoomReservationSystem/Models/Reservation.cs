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
		public Room Room { get; set; }
		public User User { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public string ReservationStatus { get; set; }
	}
}
