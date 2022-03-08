namespace Viddz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, GenreType) VALUES(1, 'Comedy')");
            Sql("INSERT INTO Genres(Id, GenreType) VALUES(2, 'Action')");
            Sql("INSERT INTO Genres(Id, GenreType) VALUES(3, 'Family')");
            Sql("INSERT INTO Genres(Id, GenreType) VALUES(4, 'Adventure')");

        }

        public override void Down()
        {
        }
    }
}
