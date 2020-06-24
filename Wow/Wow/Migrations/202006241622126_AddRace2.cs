namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRace2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Characters", "Gender", c => c.String());
            DropColumn("dbo.Races", "Gender");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Races", "Gender", c => c.String());
            DropColumn("dbo.Characters", "Gender");
        }
    }
}
