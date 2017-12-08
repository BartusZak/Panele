namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droping : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM RateValues WHERE Id > 1");
            Sql("DELETE FROM Products WHERE Id > 1");
        }
        
        public override void Down()
        {
        }
    }
}
