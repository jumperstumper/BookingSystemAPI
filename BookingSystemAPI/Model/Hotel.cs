using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemAPI.Model
{
    public class Hotel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string HotelName { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public DateTime Date { get; set; }

        public List<Room> Rooms { get; set; }
    }
}
