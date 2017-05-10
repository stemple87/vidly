namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reset : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.MembershipTypes", "DiscountName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "DiscountName", c => c.String());
        }
    }
}
