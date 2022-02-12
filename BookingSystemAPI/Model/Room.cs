using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemAPI.Model
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        public int RoomNumber { get; set; }

        public int Price { get; set; }

        public int Rating { get; set; }

        public int Size { get; set; }

        [ForeignKey("Hotel")]
        public int Hotel_Id { get; set; }
        public Hotel Hotel { get; set; }

    }
}
