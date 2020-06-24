namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsAvailableToCharacter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "isAvailable", c => c.Boolean(nullable: false));

            Sql("UPDATE Characters SET IsAvailable = 1");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Characters", "isAvailable");
        }
    }
}
