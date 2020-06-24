namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateSides : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sides (Id, Name) VALUES (1, 'Alliance')");
            Sql("INSERT INTO Sides (Id, Name) VALUES (2, 'Horde')");
            Sql("INSERT INTO Sides (Id, Name) VALUES (3, 'Both')");
        }
        
        public override void Down()
        {
        }
    }
}
