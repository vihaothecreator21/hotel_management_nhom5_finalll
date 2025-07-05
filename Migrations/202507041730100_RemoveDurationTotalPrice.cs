namespace hotel_management_nhom5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveDurationTotalPrice : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Bookings", "Duration");
            DropColumn("dbo.Bookings", "TotalPrice");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "TotalPrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Bookings", "Duration", c => c.Time(nullable: false, precision: 7));
        }
    }
}
