namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ADDingcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Category", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Category");
        }
    }
}
