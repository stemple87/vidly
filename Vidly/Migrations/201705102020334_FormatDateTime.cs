namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FormatDateTime : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Id, Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES(1, 'The Thing', 01/05/1982, 05/25/2017, 1, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
