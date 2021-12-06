using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication1.Models.Entities
{
    public sealed class DbWorkDays : DbContext
    {
        public DbWorkDays(DbContextOptions<DbWorkDays>options) : base(options)
        {
           
        }       
        public DbSet<User> Users { get; set; }
        public DbSet<Manager> Managers { get; set; }
       
        public DbSet<Schedule> Schedules { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(

            new User
            {
                Id = 1,
                FirstName = "Viktor",
                LastName = "Stepanov",
                Role = UserRole.User,
                DateRegistration = DateTime.Now,
                Email = "step@gmail.com",
                Experience = "36 month",
                Password = "1111"
            },
            new User()
            {
                Id = 2,
                FirstName = "Igor",
                LastName = "Pokimonov",
                Role = UserRole.User,
                DateRegistration = DateTime.Now,
                Email = "monov@gmail.com",
                Experience = "46 month",
                Password = "2222"
            },

            new User()
            {
                Id = 3,
                FirstName = "Ivan",
                LastName = "Pervij",
                Role = UserRole.User,
                Password = "3333",
                Experience = "12 month",
                Email = "ivan@gmail.com",
                DateRegistration = DateTime.Now
            },

            new User()
            {
                Id = 4,
                FirstName = "Tom",
                LastName = "Cruz",
                Role = UserRole.User,
                Password = "4444",
                Email = "cruz@gmail.com",
                Experience = "28 month",
                DateRegistration = DateTime.Now
            });

            modelBuilder.Entity<Manager>().HasData(
            new Manager()
            {
                Id = 1,
                DateRegistration = new DateTime(2021, 12, 2),
                FirstName = "Dmitry",
                LastName = "Cobolev",
                Role = UserRole.Admin,
                Password = "qwerty",
                Email = "cobolev@prim.com",
            },

            new Manager()
            {
                Id = 2,
                FirstName = "Semen",
                LastName = "Gogolev",
                Password = "asdfgh",
                Role = UserRole.Admin,
                Email = "gogolev@prim.com",
                DateRegistration = new DateTime(2021, 12, 1)
            });

            modelBuilder.Entity<Schedule>().HasData(
            new Schedule()
            {
                Id = 1,
                Name = "Workdays for the sprin",
                DataStart = new DateTime(2021, 4, 21),
                Duration = 5,
                DataEnd = new DateTime(2021, 4, 28),
                ManagerName = "Cobolev",
            },

            new Schedule()
            {
                Id = 2,
                Name = "Workdays for the autumn",
                DataStart = new DateTime(2021, 10, 1),
                DataEnd = new DateTime(2021, 10, 25),
                Duration = 20,
                ManagerName = "Gogolev",

            });          
        }       
    }
}

