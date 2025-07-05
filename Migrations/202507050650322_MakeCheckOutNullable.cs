namespace hotel_management_nhom5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeCheckOutNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "CheckOut", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "CheckOut", c => c.DateTime(nullable: false));
        }
    }
}
