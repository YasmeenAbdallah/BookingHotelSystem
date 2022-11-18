using System;
using System.Collections.Generic;
using System.Text;
using Booking.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Booking.DAL.Database
{
    public class BookingDbContext : DbContext
    {
        public BookingDbContext(DbContextOptions<BookingDbContext> opt) : base(opt)
        {

        }
        public DbSet<Branch> Branch { get; set; }
        public DbSet<BranchRooms> BranchRooms { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Reservations> Reservations { get; set; }
        public DbSet<ReservationStatus> ReservationStatus { get; set; }
        public DbSet<ReseverationDetails> ReseverationDetails { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<User> User { get; set; }
    }
}
