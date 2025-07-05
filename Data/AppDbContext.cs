using System.Data.Entity;
using hotel_management_nhom5.Models;

namespace hotel_management_nhom5.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=MyConnection") { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Customer (1) - (N) Booking
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Bookings)
                .WithRequired(b => b.Customer)
                .HasForeignKey(b => b.CustomerId)
                .WillCascadeOnDelete(false);

            //// Room (1) - (N) Booking
            modelBuilder.Entity<Room>()
                .HasMany(r => r.Bookings)
                .WithRequired(b => b.Room)
                .HasForeignKey(b => b.RoomId)
                .WillCascadeOnDelete(true);

            //// Booking (1) - (N) Review
            modelBuilder.Entity<Booking>()
                .HasMany(b => b.Reviews)
                .WithRequired(r => r.Booking)
                .HasForeignKey(r => r.BookingId)
                .WillCascadeOnDelete(false);

            //// Room (1) - (N) Review
            modelBuilder.Entity<Room>()
                .HasMany(r => r.Reviews)
                .WithRequired(rv => rv.Room)
                .HasForeignKey(rv => rv.RoomId)
                .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
