namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsAvailableToCharacter1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Characters", "isAvailable", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Characters", "isAvailable", c => c.Boolean(nullable: false));
        }
    }
}
