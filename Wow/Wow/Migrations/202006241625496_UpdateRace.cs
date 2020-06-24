namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRace : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sides",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Races", "SideId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Races", "SideId");
            AddForeignKey("dbo.Races", "SideId", "dbo.Sides", "Id", cascadeDelete: true);
            DropColumn("dbo.Races", "Side");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Races", "Side", c => c.String());
            DropForeignKey("dbo.Races", "SideId", "dbo.Sides");
            DropIndex("dbo.Races", new[] { "SideId" });
            DropColumn("dbo.Races", "SideId");
            DropTable("dbo.Sides");
        }
    }
}
