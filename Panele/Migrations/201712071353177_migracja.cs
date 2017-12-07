namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migracja : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RateValues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RateNumberOne = c.Int(nullable: false),
                        RateNumberTwo = c.Int(nullable: false),
                        RateNumberThree = c.Int(nullable: false),
                        RateNumberFour = c.Int(nullable: false),
                        RateNumberFive = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.Products", "numberOfVotes", c => c.Int(nullable: false));
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
            DropForeignKey("dbo.RateValues", "ProductId", "dbo.Products");
            DropIndex("dbo.RateValues", new[] { "ProductId" });
            AlterColumn("dbo.Products", "Material", c => c.String());
            AlterColumn("dbo.Products", "Description", c => c.String());
            AlterColumn("dbo.Products", "Color", c => c.String());
            AlterColumn("dbo.Products", "Type", c => c.String());
            AlterColumn("dbo.Products", "State", c => c.String());
            AlterColumn("dbo.Products", "Company", c => c.String());
            AlterColumn("dbo.Products", "Name", c => c.String());
            DropColumn("dbo.Products", "numberOfVotes");
            DropTable("dbo.RateValues");
        }
    }
}
