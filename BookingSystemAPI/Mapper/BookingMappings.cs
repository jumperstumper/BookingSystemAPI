using AutoMapper;
using BookingSystemAPI.Model;
using BookingSystemAPI.Model.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemAPI.Mapper
{
    public class BookingMappings : Profile
    {
        public BookingMappings()
        {
            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<Room, RoomDTO>().ReverseMap();
        }
    }
}
