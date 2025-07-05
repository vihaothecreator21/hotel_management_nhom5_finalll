using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace hotel_management_nhom5.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        // Foreign keys
        public int CustomerId { get; set; }
        public int RoomId { get; set; }

        // Navigation
        public Customer Customer { get; set; }
        public Room Room { get; set; }

        // Booking info
        public DateTime CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public DateTime BookingDate { get; set; }
        public BookingStatus Status { get; set; } = BookingStatus.Booked;

        // Không map xuống DB
        [NotMapped]
        public int Nights => CheckOut.HasValue ? (CheckOut.Value - CheckIn).Days : 0;

        [NotMapped]
        public decimal TotalPrice => Nights * (Room?.Price ?? 0m);

        public List<Review> Reviews { get; set; } = new List<Review>();

        // Helpers cho DataGridView
        public string GuestName => Customer?.FullName ?? "";
        public string RoomNumber => Room?.RoomNumber ?? "";
        public string CheckInOut => $"{CheckIn:dd/MM/yyyy} → {CheckOut:dd/MM/yyyy}";
    }
}
