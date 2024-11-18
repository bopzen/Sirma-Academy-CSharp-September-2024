using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomReservationSystem.Models
{
	public class Room
	{
		public int RoomNumber { get; set; }
		public RoomType Type { get; set; }
		public double PricePerNight { get; set; }
		public double CancellationFee { get; set; }
		public string Status { get; set; }

	}
}
