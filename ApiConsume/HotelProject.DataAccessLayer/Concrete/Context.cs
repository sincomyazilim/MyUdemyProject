using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.DataAccessLayer.Concrete
{
    public class Context:IdentityDbContext<AppUser,AppRole,int>
    {//v8-- 39 ıdentıt degıstı
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=LAPTOP-28U4354N\\SQLEXPRESS;initial catalog=MyUdemyProjectMuratDb;integrated security=true");
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Booking> Bookings { get; set; }//v57
        public DbSet<Guest> Guests { get; set; }//v87
        public DbSet<Contact> Contacts { get; set; }//v90
        public DbSet<SendMessage> SendMessages { get; set; }//v104
        public DbSet<CategoryContactMessage> CategoryContactMessages { get; set; }//v130
        public DbSet<WorkLocation> WorkLocations { get; set; }//v137
        public DbSet<Test> Tests { get; set; }//v137
        
    }
}
