namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES('The Blob', 01/05/1982, 05/25/2017, 1, 1)");
        }
        
        public override void Down()
        {
        }
    }
}
