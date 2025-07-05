using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using hotel_management_nhom5.Data;
using hotel_management_nhom5.Models;
using hotel_management_nhom5.Repositories.Interfaces;

namespace hotel_management_nhom5.Repositories.Implementations
{
    public class RoomRepository : IRoomRepository
    {
        private readonly AppDbContext _context;

        public RoomRepository() : this(new AppDbContext()) { }

        public RoomRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Room> GetAll() =>
            _context.Rooms.ToList();

        public IEnumerable<Room> GetAvailable() =>
            _context.Rooms.Where(r => r.Status == "Available").ToList();

        public Room GetById(int id) =>
            _context.Rooms.Find(id);

        public void Add(Room room)
        {
            _context.Rooms.Add(room);
            _context.SaveChanges();
        }

        public void Update(Room room)
        {
            var existing = _context.Rooms.Find(room.RoomId);
            if (existing == null) return;

            // Gán các trường cần cập nhật
            existing.RoomNumber = room.RoomNumber;
            existing.Type = room.Type;
            existing.Status = room.Status;
            existing.ImageKey = room.ImageKey;
            existing.Price = room.Price;
            existing.Capacity = room.Capacity;
            existing.Description = room.Description;

            _context.SaveChanges();
        }

        /// <summary>
        /// Chỉ đổi status, giữ nguyên các field khác
        /// </summary>
        public void ChangeStatus(int roomId, string newStatus)
        {
            var r = _context.Rooms.Find(roomId);
            if (r == null) return;
            r.Status = newStatus;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var room = _context.Rooms.Find(id);
            if (room == null) return;
            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }
    }
}
