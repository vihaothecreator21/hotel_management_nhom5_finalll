using System;

namespace hotel_management_nhom5.Models
{
    public class Review
    {
        public int Id { get; set; }

        // Foreign keys
        public int BookingId { get; set; }
        public int RoomId { get; set; }

        // Navigation
        public Booking Booking { get; set; }
        public Room Room { get; set; }

        public int Rating { get; set; }  // 1–5
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
