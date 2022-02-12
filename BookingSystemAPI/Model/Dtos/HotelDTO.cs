using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemAPI.Model.Dtos
{
    public class HotelDTO
    {

        public int Id { get; set; }

        public string HotelName { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public DateTime Date { get; set; }

        //public List<Room> Rooms { get; set; }
    }
}
