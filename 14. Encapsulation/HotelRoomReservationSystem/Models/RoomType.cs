using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoomReservationSystem.Models
{
	public class RoomType
	{
		public string Name { get; set; }
		public int MaxOccupancy { get; set; }
		public List<string> Amenities { get; set; }
    }
}
