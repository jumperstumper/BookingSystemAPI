using AutoMapper;
using BookingSystemAPI.Data;
using BookingSystemAPI.Model.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemAPI.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public HotelController(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetHotels()
        {

            var objList = _db.Hotel.OrderBy(a => a.HotelName).ToList();
            var objDto = new List<HotelDTO>();

            foreach (var obj in objList)
            {
                objDto.Add(_mapper.Map<HotelDTO>(obj));
            }

            return Ok(objList);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetHotel(int id)
        {

            var obj = _db.Hotel.FirstOrDefault(x => x.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            var objDto = _mapper.Map<HotelDTO>(obj);

            return Ok(objDto);
        }

   

    }
}
