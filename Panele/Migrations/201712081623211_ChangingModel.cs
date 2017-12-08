namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingModel : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Products WHERE Id > 1");
            Sql("DELETE FROM RateValues WHERE Id > 1");
            AddColumn("dbo.Products", "Model", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Model");
        }
    }
}
