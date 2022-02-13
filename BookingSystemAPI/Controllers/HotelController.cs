using AutoMapper;
using BookingSystemAPI.Data;
using BookingSystemAPI.Model;
using BookingSystemAPI.Model.Dtos;
using BookingSystemAPI.Repository.IRepository;
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
        private readonly IHotelRepo _hotelRepo;

        public HotelController(ApplicationDbContext db, IMapper mapper /*IHotelRepo hotelRepo*/)
        {
            _db = db;
            _mapper = mapper;
            //_hotelRepo = hotelRepo;
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

        [HttpGet("{id:int}", Name = "GetHotel")]
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


        [HttpPost]
        public IActionResult CreateHotel([FromBody] HotelDTO hotelDTO)
        {

            if (hotelDTO == null)
            {
                return BadRequest(ModelState);
            }
         
            var hotelObj = _mapper.Map<Hotel>(hotelDTO);

            return Ok(hotelObj);
        }


    }
}
