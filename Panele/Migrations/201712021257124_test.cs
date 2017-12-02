namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Company = c.String(),
                        Cost = c.Double(nullable: false),
                        AddDate = c.DateTime(nullable: false),
                        State = c.String(),
                        Type = c.String(),
                        Rate = c.Double(nullable: false),
                        Width = c.Double(nullable: false),
                        Lenght = c.Double(nullable: false),
                        Height = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        Greg = c.Double(nullable: false),
                        Color = c.String(),
                        Description = c.String(),
                        Material = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
