using BookingSystemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemAPI.Repository.IRepository
{
    interface IHotelRepo
    {
        bool CreateHotel(Hotel hotel);
        bool Save();
    }
}
