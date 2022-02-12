using BookingSystemAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookingSystemAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Room> Room { get; set; }



    }    
}

