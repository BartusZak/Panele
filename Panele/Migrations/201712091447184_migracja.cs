namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Model", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Products", "Category", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Category");
            DropColumn("dbo.Products", "Model");
        }
    }
}
