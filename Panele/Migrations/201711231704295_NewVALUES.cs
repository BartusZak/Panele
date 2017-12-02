namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewVALUES : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Rate", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Width", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Lenght", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Height", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Weight", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Greg", c => c.Double(nullable: false));
            AddColumn("dbo.Products", "Color", c => c.String());
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "Material", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Material");
            DropColumn("dbo.Products", "Description");
            DropColumn("dbo.Products", "Color");
            DropColumn("dbo.Products", "Greg");
            DropColumn("dbo.Products", "Weight");
            DropColumn("dbo.Products", "Height");
            DropColumn("dbo.Products", "Lenght");
            DropColumn("dbo.Products", "Width");
            DropColumn("dbo.Products", "Rate");
        }
    }
}
