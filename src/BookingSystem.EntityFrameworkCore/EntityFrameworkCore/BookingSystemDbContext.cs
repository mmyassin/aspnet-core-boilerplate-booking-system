using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using BookingSystem.Authorization.Roles;
using BookingSystem.Authorization.Users;
using BookingSystem.MultiTenancy;
using BookingSystem.Cities;
using BookingSystem.Jets;
using BookingSystem.Flights;

namespace BookingSystem.EntityFrameworkCore
{
    public class BookingSystemDbContext : AbpZeroDbContext<Tenant, Role, User, BookingSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Flight> Flights { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Jet> Jets { get; set; }
        public virtual DbSet<BookedTicket> BookedTickets { get; set; }
        public BookingSystemDbContext(DbContextOptions<BookingSystemDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            // Removes table prefixes. You can specify another prefix.
            modelBuilder.ChangeAbpTablePrefix<Tenant, Role, User>(""); 
        }
    }
}
