namespace Viddz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre) VALUES ('Shrek In Space!', 'Family fun time')");
            Sql("INSERT INTO Movies (Name, Genre) VALUES ('Shrek Gets Lost!', 'Family fun time')");
            Sql("INSERT INTO Movies (Name, Genre) VALUES ('Shrek Says NO!', 'Fun time')");
            Sql("INSERT INTO Movies (Name, Genre) VALUES ('Shrek Loses Everything!', 'Time')");

        }

        public override void Down()
        {
        }
    }
}
