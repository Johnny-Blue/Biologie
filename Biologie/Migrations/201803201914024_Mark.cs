namespace Biologie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mark : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rezultats", "Mark", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rezultats", "Mark");
        }
    }
}
