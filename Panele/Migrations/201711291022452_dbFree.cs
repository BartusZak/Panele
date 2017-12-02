namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbFree : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Products WHERE Id > 24");
        }
        
        public override void Down()
        {
        }
    }
}
