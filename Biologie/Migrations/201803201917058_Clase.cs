namespace Biologie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Clase : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clasas", newName: "Clase");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Clase", newName: "Clasas");
        }
    }
}
