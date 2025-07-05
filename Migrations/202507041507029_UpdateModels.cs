namespace hotel_management_nhom5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bookings", "Duration", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Bookings", "CheckOut", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "CheckOut", c => c.DateTime());
            DropColumn("dbo.Bookings", "Duration");
        }
    }
}
