namespace hotel_management_nhom5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoomCascadeDelete : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Reviews", "RoomId", "dbo.Rooms");
            AddForeignKey("dbo.Bookings", "RoomId", "dbo.Rooms", "RoomId", cascadeDelete: true);
            AddForeignKey("dbo.Reviews", "RoomId", "dbo.Rooms", "RoomId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.Bookings", "RoomId", "dbo.Rooms");
            AddForeignKey("dbo.Reviews", "RoomId", "dbo.Rooms", "RoomId");
            AddForeignKey("dbo.Bookings", "RoomId", "dbo.Rooms", "RoomId");
        }
    }
}
