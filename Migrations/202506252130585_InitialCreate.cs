namespace hotel_management_nhom5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        CheckIn = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        Duration = c.Time(nullable: false, precision: 7),
                        TotalPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BookingDate = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookingId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .ForeignKey("dbo.Rooms", t => t.RoomId)
                .Index(t => t.CustomerId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        IdentityCard = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookingId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        Comment = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        Customer_CustomerId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Rooms", t => t.RoomId)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId)
                .ForeignKey("dbo.Bookings", t => t.BookingId)
                .Index(t => t.BookingId)
                .Index(t => t.RoomId)
                .Index(t => t.Customer_CustomerId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        RoomNumber = c.String(),
                        Type = c.String(),
                        ImageKey = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(),
                        Capacity = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.RoomId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "BookingId", "dbo.Bookings");
            DropForeignKey("dbo.Reviews", "Customer_CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Reviews", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Bookings", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Reviews", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Reviews", new[] { "RoomId" });
            DropIndex("dbo.Reviews", new[] { "BookingId" });
            DropIndex("dbo.Bookings", new[] { "RoomId" });
            DropIndex("dbo.Bookings", new[] { "CustomerId" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Reviews");
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
        }
    }
}
