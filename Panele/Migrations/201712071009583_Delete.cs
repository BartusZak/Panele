namespace Panele.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM RateValues WHERE Id >=35");
        }
        
        public override void Down()
        {
        }
    }
}
