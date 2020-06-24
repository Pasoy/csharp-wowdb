namespace Wow.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPicks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Picks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DatePicked = c.DateTime(nullable: false),
                        DateReturned = c.DateTime(),
                        Character_Id = c.Int(nullable: false),
                        Player_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Characters", t => t.Character_Id, cascadeDelete: true)
                .ForeignKey("dbo.Players", t => t.Player_Id, cascadeDelete: true)
                .Index(t => t.Character_Id)
                .Index(t => t.Player_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Picks", "Player_Id", "dbo.Players");
            DropForeignKey("dbo.Picks", "Character_Id", "dbo.Characters");
            DropIndex("dbo.Picks", new[] { "Player_Id" });
            DropIndex("dbo.Picks", new[] { "Character_Id" });
            DropTable("dbo.Picks");
        }
    }
}
