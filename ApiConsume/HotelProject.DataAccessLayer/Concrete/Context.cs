using HotelProject.EntityLayer.Concrate;
using HotelProject.EntityLayer.Conctate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLAyer.Concrate
{
   public class Context:IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-6O8K1CV\\SQLEXPRESS;initial catalog=ApiDb;integrated security=true");
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Staff> staffs { get; set; }
        public DbSet<Subscrabe> subscrabes { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings{ get; set; }
        public DbSet<Guest> Guests{ get; set; }
        public DbSet<Contact> Contacts{ get; set; }
        public DbSet<SendMessage> SendMessages{ get; set; }
        public DbSet<MessageCategory> MessageCategories{ get; set; }
        public DbSet<WorkLocation> WorkLocations{ get; set; }
    }
}
