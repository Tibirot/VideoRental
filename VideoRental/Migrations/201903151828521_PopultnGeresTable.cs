namespace VideoRental.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopultnGeresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Crime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Documentary')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Drama')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Fantasy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Historical')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (9, 'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (10, 'Mystery')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (11, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (12, 'Sci-Fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (13, 'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
