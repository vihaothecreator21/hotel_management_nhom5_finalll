namespace hotel_management_nhom5.Migrations
{
    using hotel_management_nhom5.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration
    : DbMigrationsConfiguration<Data.AppDbContext>
    {
        public Configuration()
        {
            // Cho phép tự động tạo migration
            AutomaticMigrationsEnabled = true;

            // Cho phép áp migration ngay cả khi có khả năng mất dữ liệu
            AutomaticMigrationDataLossAllowed = true;
        
        }

        protected override void Seed(Data.AppDbContext context)
        {
            context.Rooms.AddOrUpdate(
                r => r.RoomNumber, // Use RoomNumber to check for duplicates
                new Room { RoomNumber = "101", Type = "Single", ImageKey = "room101", Price = 500000, Status = "Available", Capacity = 1, Description = "Cozy single room." },
                new Room { RoomNumber = "202", Type = "Double", ImageKey = "room202", Price = 700000, Status = "Available", Capacity = 2, Description = "Spacious double room." },
                new Room { RoomNumber = "303", Type = "Suite", ImageKey = "room303", Price = 1200000, Status = "Available", Capacity = 4, Description = "Luxury suite with living area." },
                new Room { RoomNumber = "104", Type = "Single", ImageKey = "room104", Price = 500000, Status = "Maintenance", Capacity = 1, Description = "Single room under maintenance." },
                new Room { RoomNumber = "205", Type = "Double", ImageKey = "room205", Price = 750000, Status = "Booked", Capacity = 2, Description = "Booked double room." },
                new Room { RoomNumber = "306", Type = "Suite", ImageKey = "room306", Price = 1300000, Status = "Available", Capacity = 4, Description = "Top floor suite." },
                new Room { RoomNumber = "107", Type = "Single", ImageKey = "room107", Price = 520000, Status = "Available", Capacity = 1, Description = "Quiet single room." }
            );

            context.SaveChanges();
        }
    }
}
