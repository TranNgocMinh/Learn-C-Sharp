namespace ManagingData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailKH : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Khoas", "EmailKH", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Khoas", "EmailKH");
        }
    }
}
