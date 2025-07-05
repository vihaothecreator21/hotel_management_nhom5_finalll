using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_management_nhom5.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public string Type { get; set; }
        public string ImageKey { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public int Capacity { get; set; }
        public string Description { get; set; }

        // Navigation
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
