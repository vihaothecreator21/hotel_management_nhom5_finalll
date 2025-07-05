using System.Linq;
using System.Collections.Generic;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5.Repositories.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _db = new AppDbContext();

        public IEnumerable<Customer> GetAll() =>
            _db.Customers.OrderByDescending(c => c.CreatedAt).ToList();

        public Customer GetById(int id) =>
            _db.Customers.Find(id);

        public Customer GetByIdentity(string identityCard) =>
            _db.Customers.FirstOrDefault(c => c.IdentityCard == identityCard);

        public void Add(Customer c)
        {
            _db.Customers.Add(c);
            _db.SaveChanges();
        }

        public void Update(Customer c)
        {
            _db.Entry(c).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var c = _db.Customers.Find(id);
            if (c != null)
            {
                _db.Customers.Remove(c);
                _db.SaveChanges();
            }
        }
    }
}
