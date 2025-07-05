using System.Collections.Generic;
using System.Data.Entity;            // EF6
using System.Linq;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5.Repositories.Implementations
{
    public class ReviewRepository : IReviewRepository
    {
        private readonly AppDbContext _db = new AppDbContext();

        // Phương thức Dashboard đang gọi
        public List<Review> GetList()
        {
            return _db.Reviews
                      .Include(r => r.Booking)
                      .ToList();
        }

        // Nếu bạn cần GetAll, giữ nguyên hoặc gọi GetList
        public IEnumerable<Review> GetAll() => GetList();

        public void Add(Review r)
        {
            _db.Reviews.Add(r);
            _db.SaveChanges();
        }
    }
}
