namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNewTableRateVAlues : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RateValues", "ProductId", "dbo.Products");
            DropIndex("dbo.RateValues", new[] { "ProductId" });
            DropTable("dbo.RateValues");
        }
    }
}
