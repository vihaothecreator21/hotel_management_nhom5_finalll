using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotel_management_nhom5.Models;

namespace hotel_management_nhom5.Repositories.Interfaces
{
    public interface IReviewRepository
    {
        IEnumerable<Review> GetAll();
        void Add(Review r);
    }
}
