using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hotel_management_nhom5.Models;

namespace hotel_management_nhom5.Repositories.Interfaces
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetAll();
        IEnumerable<Booking> GetByCustomer(int customerId);
        Booking GetActiveByCustomer(int customerId);
        void Add(Booking r);
        void Update(Booking r);
    }
}