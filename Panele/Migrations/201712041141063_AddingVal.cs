namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingVal : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "Company", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Products", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Color", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Material", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Material", c => c.String());
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "Color", c => c.String());
            AlterColumn("dbo.Products", "Type", c => c.String());
            AlterColumn("dbo.Products", "State", c => c.String());
            AlterColumn("dbo.Products", "Company", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
