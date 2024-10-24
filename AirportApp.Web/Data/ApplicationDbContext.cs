using AirportApp.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AirportApp.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<Airline> Airlines { get; set; }
        public virtual DbSet<Aircraft> Aircrafts { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
        public virtual DbSet<Booking> Bookings { get; set; }
        public virtual DbSet<StaffMember> StaffMembers { get; set;}
        public virtual DbSet<Terminal> Terminals { get; set; }
        public virtual DbSet<Gate> Gates { get; set; }
        public virtual DbSet<Baggage> Baggages { get; set; }
        public virtual DbSet<FlightStaffMember> FlightsStaffMembers { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}
    }
}
