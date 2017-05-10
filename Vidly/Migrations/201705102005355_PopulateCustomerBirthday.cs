namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerBirthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = '05/25/1950' Where ID = 2");
        }
        
        public override void Down()
        {
        }
    }
}
