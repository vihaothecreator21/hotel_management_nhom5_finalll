using System.Collections.Generic;
using System.Data.Entity;  // EF6
using System.Linq;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5.Repositories.Implementations
{
    public class BookingRepository : IBookingRepository
    {
        private readonly AppDbContext _db = new AppDbContext();

        /// <summary>
        /// Chỉ trả về những booking đã có giá trị CheckOut (non-null),
        /// dùng cho thống kê doanh thu và biểu đồ.
        /// </summary>
        public List<Booking> GetList()
        {
            return _db.Bookings
                      .Where(b => b.CheckOut != null)
                      .Include(b => b.Room)
                      .Include(b => b.Customer)
                      .ToList();
        }

        /// <summary>
        /// Lấy toàn bộ booking bao gồm cả chưa CheckOut.
        /// </summary>
        public List<Booking> GetAllIncludingCheckOutNull()
        {
            return _db.Bookings
                      .Include(b => b.Room)
                      .Include(b => b.Customer)
                      .ToList();
        }

        public IEnumerable<Booking> GetAll() => GetList();

        public IEnumerable<Booking> GetByCustomer(int custId) =>
            _db.Bookings
               .Include(b => b.Room)
               .Include(b => b.Customer)
               .Where(b => b.CustomerId == custId)
               .ToList();

        public Booking GetActiveByCustomer(int custId) =>
            _db.Bookings
               .Include(b => b.Room)
               .Include(b => b.Customer)
               .FirstOrDefault(b =>
                   b.CustomerId == custId &&
                   b.Status != BookingStatus.CheckedOut);

        public void Add(Booking r)
        {
            _db.Bookings.Add(r);
            _db.SaveChanges();
        }

        public void Update(Booking r)
        {
            _db.Entry(r).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
