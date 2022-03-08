namespace Viddz.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayToCustomerModel : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthday = 'April 2, 1980' WHERE Id = 1");
            Sql("UPDATE Customers SET Birthday = 'June 12, 1964' WHERE Id = 3"); 
           
        }
        
        public override void Down()
        {
        }
    }
}
