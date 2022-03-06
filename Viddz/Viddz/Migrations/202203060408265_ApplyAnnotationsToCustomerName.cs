namespace Viddz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ApplyAnnotationsToCustomerName : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Customer_Id", "dbo.Customers");
            DropIndex("dbo.Customers", new[] { "Customer_Id" });
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.Customers", "Customer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Customer_Id", c => c.Int());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            CreateIndex("dbo.Customers", "Customer_Id");
            AddForeignKey("dbo.Customers", "Customer_Id", "dbo.Customers", "Id");
        }
    }
}
