namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRace1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Races",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                        Side = c.String(),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Characters", "RaceId");
            AddForeignKey("dbo.Characters", "RaceId", "dbo.Races", "Id", cascadeDelete: true);
            DropColumn("dbo.Characters", "Race");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Characters", "Race", c => c.String(nullable: false));
            DropForeignKey("dbo.Characters", "RaceId", "dbo.Races");
            DropIndex("dbo.Characters", new[] { "RaceId" });
            DropTable("dbo.Races");
        }
    }
}
