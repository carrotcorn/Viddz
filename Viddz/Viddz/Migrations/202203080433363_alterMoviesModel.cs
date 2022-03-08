namespace Viddz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class alterMoviesModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);
            AlterColumn("dbo.Customers", "Birthday", c => c.DateTime(nullable: true));
           
        }
        
        public override void Down()
        {
            
                DropTable("dbo.Movies");
            
            
            AlterColumn("dbo.Customers", "Birthday", c => c.String());
        }
    }
}
