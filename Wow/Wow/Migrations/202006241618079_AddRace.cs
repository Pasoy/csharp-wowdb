namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRace : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "RaceId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Characters", "Race", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Characters", "Race", c => c.String());
            DropColumn("dbo.Characters", "RaceId");
        }
    }
}
