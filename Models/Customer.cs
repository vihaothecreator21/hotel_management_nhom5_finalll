using System;
using System.Collections.Generic;

namespace hotel_management_nhom5.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string IdentityCard { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation
        public List<Booking> Bookings { get; set; } = new List<Booking>();
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
