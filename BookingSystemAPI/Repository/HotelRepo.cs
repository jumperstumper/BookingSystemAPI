using BookingSystemAPI.Data;
using BookingSystemAPI.Model;
using BookingSystemAPI.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemAPI.Repository
{
    public class HotelRepo : IHotelRepo
    {
        private readonly ApplicationDbContext _db;

        public HotelRepo(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CreateHotel(Hotel hotel)
        {
            _db.Hotel.Add(hotel);
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }
    }
}
