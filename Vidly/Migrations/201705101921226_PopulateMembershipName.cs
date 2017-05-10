namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipName = 'Pay as You Go' Where ID = 1");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Monthly' Where ID = 2");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Seasonal' Where ID = 3");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Yearly' Where ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
