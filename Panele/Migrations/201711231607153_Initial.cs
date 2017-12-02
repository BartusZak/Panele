namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ProductDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.ProductDetails", new[] { "ProductId" });
            DropColumn("dbo.Products", "Type");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ProductDetails",
                c => new
                    {
                        ProductDetailsID = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Description = c.String(),
                        Width = c.Double(nullable: false),
                        Lenght = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        Color = c.String(),
                        Gage = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductDetailsID);
            
            AddColumn("dbo.Products", "Type", c => c.String());
            CreateIndex("dbo.ProductDetails", "ProductId");
            AddForeignKey("dbo.ProductDetails", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
        }
    }
}
